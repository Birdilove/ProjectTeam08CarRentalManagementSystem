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

        private void InitializeStudentRegistrationFormsAppMainForm()
        {
            CarRentalManagementEntities context = new CarRentalManagementEntities();
            //context.SeedDatabase();

            //Calling method that initializes all of the datagrids.
            InitializeDataGridView<Reservation>(dataGridViewAvailableCars);
            InitializeDataGridView<Reservation>(dataGridViewRentedCars);
        }

        private void InitializeDataGridView<T>(DataGridView datagridView, params string[] columnsToHide) where T : class
        {
            datagridView.AllowUserToAddRows = false;
            datagridView.AllowUserToDeleteRows = true;
            datagridView.ReadOnly = true;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView.DataSource = Controller<CarRentalManagementEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
            {
                datagridView.Columns[column].Visible = false;
            }
        }
    }
}
