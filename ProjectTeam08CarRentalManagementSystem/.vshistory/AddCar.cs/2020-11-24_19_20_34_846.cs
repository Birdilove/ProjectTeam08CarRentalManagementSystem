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
        AddType addType;
        public AddCar()
        {
            InitializeComponent();
            add_Make = new Add_Make();
            addType = new AddType();
            buttonCarMake.Click += ButtonCarMake_Click;
            addType.Click += AddType_Click;
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            addType.ShowDialog();
        }

        private void ButtonCarMake_Click(object sender, EventArgs e)
        {
            add_Make.ShowDialog();
        }
    }
}
