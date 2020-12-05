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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            InitializeAdminForm();

            buttonAddNewCar.Click += ButtonAddNewCar_Click;
            buttonViewReports.Click += ButtonViewReports_Click;
        }

        private void ButtonViewReports_Click(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.ShowDialog();
        }

        private void ButtonAddNewCar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.ShowDialog();
        }

        public void InitializeAdminForm()
        {
            InitializeDataGridView<Reservation>(dataGridViewRentedCars, "CarId", "TypeId", "MakeId", "CarMake", "CarType");
            InitializeDataGridView<Car>(dataGridViewAvailableCars, "CarId", "TypeId", "MakeId", "CarMake", "CarType");
            LoadAvailableCars();
            LoadReseverdCars();
        }

        private void InitializeDataGridView<T>(DataGridView datagridView, params string[] columnsToHide) where T : class
        {
            datagridView.AllowUserToAddRows = false;
            datagridView.AllowUserToDeleteRows = true;
            datagridView.ReadOnly = true;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //datagridView.UserDeletingRow += (s, e) => DeleteRow<T>(s as DataGridView, e);
            datagridView.DataError += (s, e) => HandleExceptions<T>(s as DataGridView, e);
            datagridView.DataSource = Controller<CarRentalManagementEntities, T>.SetBindingList();
            foreach (string column in columnsToHide)
            {
                datagridView.Columns[column].Visible = false;
            }
        }

        public void LoadAvailableCars()
        {
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();
            dataGridViewAvailableCars.DataSource = Controller<CarRentalManagementEntities, Car>.GetEntities(c => !carIds.Contains(c.CarId)).ToList();
        }

        public void LoadReseverdCars()
        {
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();
            dataGridViewRentedCars.DataSource = Controller<CarRentalManagementEntities, Car>.GetEntities(c => carIds.Contains(c.CarId)).ToList();
        }

        private void HandleExceptions<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
