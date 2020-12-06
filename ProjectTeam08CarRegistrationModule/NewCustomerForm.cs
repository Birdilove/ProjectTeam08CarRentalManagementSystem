using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementCodeFirstFromDB;
using EFControllerUtilities;

namespace ProjectTeam08CarRegistrationModule
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = textBoxfirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.PhoneNumber = textBoxPhoneNumber.Text;
            Controller<CarRentalManagementEntities, Customer>.AddEntity(customer);
              this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
