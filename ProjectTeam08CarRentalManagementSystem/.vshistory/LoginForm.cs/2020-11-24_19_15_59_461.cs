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
    public partial class LoginForm : Form
    {
        AdminForm adminForm;
        public LoginForm()
        {
            InitializeComponent();
            adminForm = new AdminForm();
            buttonLogin.Click += ButtonLogin_Click;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            RadioButtun_State(null, null);
        }

        private void RadioButtun_State(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked)
            {
                adminForm.ShowDialog();
            }
            else if (radioButtonUser.Checked)
            {
                
            }
            else
            {
                MessageBox.Show("Please select user type!");
            }
        }

       
    }
}
