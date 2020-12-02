using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using CarRentalManagementCodeFirstFromDB;

namespace ProjectTeam08CarRentalManagementSystem
{
    public partial class Add_Make : Form
    {
        public Add_Make()
        {
            InitializeComponent();
            buttonAddCarMake.Click += ButtonAddCarMake_Click;
        }

        private void ButtonAddCarMake_Click(object sender, EventArgs e)
        {
            CarRentalManagementEntities entities = new CarRentalManagementEntities();
            CarMake carMake = new CarMake()
            {
                Make = textBoxAddCarMake.Text
            };

            try
            {
                entities.CarMakes.Add(carMake);
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Car Make to database" + ex.InnerException.InnerException.Message);
                return;
            }
           
            this.DialogResult = DialogResult.OK;
            entities.Dispose();
            Close();
        }
    }
}
