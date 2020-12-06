using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTeam08CarRegistrationModule;


namespace ProjectTeam08CarRentalManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            buttonLogin.Click += ButtonLogin_Click;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            if (radioButtonUser.Checked)
            {
                RegistrationForm regForm = new RegistrationForm();
                regForm.ShowDialog();
            }
        }
    }
}
