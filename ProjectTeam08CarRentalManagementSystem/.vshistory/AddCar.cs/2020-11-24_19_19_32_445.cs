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
    public partial class AddCar : Form
    {
        Add_Make add_Make;
        public AddCar()
        {
            InitializeComponent();
            add_Make = new Add_Make();
            buttonCarMake.Click += ButtonCarMake_Click;
        }

        private void ButtonCarMake_Click(object sender, EventArgs e)
        {
            add_Make.ShowDialog();
        }
    }
}
