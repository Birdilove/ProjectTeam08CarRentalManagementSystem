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
        private CarRentalManagementEntities context;
        private DataSet rentalDataSet;
        public AdminForm()
        {
            rentalDataSet = new DataSet()
            {
                DataSetName = "rentalDataSet",
            };
            context = new CarRentalManagementEntities();
            InitializeComponent();
            InitializeAdminForm();
            buttonAddNewCar.Click += ButtonAddNewCar_Click;
            buttonViewReports.Click += ButtonViewReports_Click;
            buttonMoveToAvailable.Click += ButtonMoveToAvailable_Click;
            buttonBackupDatabase.Click += ButtonBackupDatabase_Click;
        }

        private void ButtonBackupDatabase_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            datagridView.MultiSelect = false;
            datagridView.ReadOnly = true;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView.DataError += (s, e) => HandleExceptions<T>(s as DataGridView, e);
            datagridView.DataSource = Controller<CarRentalManagementEntities, T>.SetBindingList();
            foreach (string column in columnsToHide)
            {
                datagridView.Columns[column].Visible = false;
            }
        }

        /// <summary>
        /// Method to load the list of available cars.
        /// </summary>
        public void LoadAvailableCars()
        {
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


        /// <summary>
        /// Method to load the list of rented cars.
        /// </summary>
        public void LoadReseverdCars()
        {
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();
            List<Car> cars = Controller<CarRentalManagementEntities, Car>.GetEntities(c => carIds.Contains(c.CarId)).ToList();
            
            var rentedCars = (from s in cars
                         join cs in context.CarTypes on s.TypeId equals cs.TypeId
                         join os in context.CarMakes on s.MakeId equals os.MakeId
                         select new
                         {
                             CarId = s.CarId,
                             CarMake = os.Make,
                             CarType = cs.Type,
                             Model = s.Model,
                             Year = s.Year,
                             Price = s.Price
                         }).ToList();

            dataGridViewRentedCars.DataSource = rentedCars;
        }


        /// <summary>
        /// Method to move a car from rented to available.
        /// </summary>
        public void MoveToAvailable()
        {
            int selectedrowindexCarId = dataGridViewRentedCars.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowCarId = dataGridViewRentedCars.Rows[selectedrowindexCarId];
            string carId = Convert.ToString(selectedRowCarId.Cells["CarId"].Value);
            Reservation res = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => r.CarId == Int32.Parse(carId) && !r.IsReturend).First();
            res.IsReturend = true;
            Controller<CarRentalManagementEntities, Reservation>.UpdateEntity(res);
            LoadReseverdCars();
            LoadAvailableCars();
        }


        /// <summary>
        /// Method to handle exceptions.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleExceptions<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public void BackupDataSetToXML()
        {
            if (hotelDataSet == null)
            {
                Debug.WriteLine("BackupDataSetToXML: Error - null dataset");
                return;
            }

            
            Debug.WriteLine("BackupDataSetToXML: backing up to " + hotelDataSet);

            hotelDataSet.WriteXml(hotelDataSet.DataSetName + ".xml", XmlWriteMode.WriteSchema);
        }
    }
}
