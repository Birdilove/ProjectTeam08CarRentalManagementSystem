﻿using System;
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
            adminForm.ShowDialog();
        }

        private void RadioButtunAdmin(object sender, EventArgs e)
        {

        }

       
    }
}
