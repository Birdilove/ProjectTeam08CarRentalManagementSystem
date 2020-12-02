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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
            buttonAddCarType.Click += ButtonAddCarType_Click;
        }

        private void ButtonAddCarType_Click(object sender, EventArgs e)
        {
            AddNewType();
        }

        public void AddNewType()
        {
            CarRentalManagementEntities entities = new CarRentalManagementEntities();
            CarType carType = new CarType()
            {
                Type = textBoxCarType.Text
            };

            try
            {
                entities.CarTypes.Add(carType);
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add Car Type to database" + ex.InnerException.InnerException.Message);
                return;
            }

            this.DialogResult = DialogResult.OK;
            entities.Dispose();
            Close();
        }
    }
}
