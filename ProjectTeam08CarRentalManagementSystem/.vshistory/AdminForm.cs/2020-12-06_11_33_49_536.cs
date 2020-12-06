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
            buttonMoveToAvailable.Click += ButtonMoveToAvailable_Click;
        }

        private void ButtonMoveToAvailable_Click(object sender, EventArgs e)
        {
            MoveToAvailable();
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
            InitializeDataGridView<Reservation>(dataGridViewRentedCars,"CarId");
            InitializeDataGridView<Car>(dataGridViewAvailableCars, "CarId", "TypeId", "MakeId");
            LoadAvailableCars();
            LoadReseverdCars();
        }

        private void InitializeDataGridView<T>(DataGridView datagridView, params string[] columnsToHide) where T : class
        {
            datagridView.AllowUserToAddRows = false;
            datagridView.AllowUserToDeleteRows = true;
            datagridView.ReadOnly = true;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView.DataError += (s, e) => HandleExceptions<T>(s as DataGridView, e);
            datagridView.DataSource = Controller<CarRentalManagementEntities, T>.SetBindingList();
            foreach (string column in columnsToHide)
            {
                datagridView.Columns[column].Visible = false;
            }
        }

        public void LoadAvailableCars()
        {
            CarRentalManagementEntities context = new CarRentalManagementEntities();
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();
            List<Car> cars = Controller<CarRentalManagementEntities, Car>.GetEntities(c => !carIds.Contains(c.CarId)).ToList();
            var availableCars = (from s in cars
                              join cs in context.CarTypes on s.TypeId equals cs.TypeId
                              join os in context.CarMakes on s.MakeId equals os.MakeId
                              select new
                              {
                                  CarId = s.CarId,
                                  MakeId = s.MakeId,
                                  CarMake = os.Make,
                                  CarType = cs.Type,
                                  Model = s.Model,
                                  Year = s.Year,
                                  Price = s.Price
                              }).ToList();

            dataGridViewAvailableCars.DataSource = availableCars;
        }

        public void LoadReseverdCars()
        {
            CarRentalManagementEntities context = new CarRentalManagementEntities();
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();
            List<Car> cars = Controller<CarRentalManagementEntities, Car>.GetEntities(c => carIds.Contains(c.CarId)).ToList();
            
            var rentedCars = (from s in cars
                         join cs in context.CarTypes on s.TypeId equals cs.TypeId
                         join os in context.CarMakes on s.MakeId equals os.MakeId
                         select new
                         {
                             CarId = s.CarId,
                             MakeId = s.MakeId,
                             CarMake = os.Make,
                             CarType = cs.Type,
                             Model = s.Model,
                             Year = s.Year,
                             Price = s.Price
                         }).ToList();

            dataGridViewRentedCars.DataSource = rentedCars;
        }

        public void MoveToAvailable()
        {
            CarRentalManagementEntities context = new CarRentalManagementEntities();
            int selectedrowindexCarId = dataGridViewAvailableCars.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowCarId = dataGridViewAvailableCars.Rows[selectedrowindexCarId];
            string carId = Convert.ToString(selectedRowCarId.Cells["CarId"].Value);

            Reservation res = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => r.CarId == Int32.Parse(carId)).First();
            res.IsReturend = true;
            Controller<CarRentalManagementEntities, Reservation>.UpdateEntity(res);
            this.Close();
        }

        private void HandleExceptions<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
