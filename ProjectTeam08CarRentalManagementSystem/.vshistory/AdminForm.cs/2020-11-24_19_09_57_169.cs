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
    public partial class AdminForm : Form
    {
        AddCar addCar;
        public AdminForm()
        {
            InitializeComponent();
            addCar = new AddCar();
            buttonAddNewCar.Click += ButtonAddNewCar_Click;
        }

        private void ButtonAddNewCar_Click(object sender, EventArgs e)
        {
            addCar.ShowDialog();
        }
    }
}
