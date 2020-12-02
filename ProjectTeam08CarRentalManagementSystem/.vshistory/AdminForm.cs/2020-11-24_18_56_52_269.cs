using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam08CarRentalManagementSystem
{
    public partial class Form1 : Form
    {
        AddCar addCar;
        public Form1()
        {
            InitializeComponent();
            AddCar addCar = new AddCar();
            buttonAddNewCar.Click += ButtonAddNewCar_Click;
        }

        private void ButtonAddNewCar_Click(object sender, EventArgs e)
        {
            addCar.ShowDialog();
        }
    }
}
