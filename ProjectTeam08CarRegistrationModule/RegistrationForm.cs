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
    public partial class RegistrationForm : Form
    {
        List<Car> cars;
        public RegistrationForm()
        {
            InitializeComponent();
            initFormData();
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new NewCustomerForm();
            newCustomerForm.Show();
        }

        private void initFormData()
        {
            listBoxReturnCars.Visible = false;
            labelReturnCar.Visible = false;
            buttonReturnCar.Visible = false;
            fetchCarTypes();
            fetchCustomers();
        }

        private void fetchCarTypes()
        {
            List<String> carTypes = Controller<CarRentalManagementEntities, CarType>.GetEntities().GroupBy(c => c.Type).Select(c => c.Key).ToList();
            comboBoxCarType.DataSource = carTypes;
        }

        private void fetchAvailableCars()
        {
            List<Reservation> reservations = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => !r.IsReturend).ToList();
            List<int> carIds = reservations.Where(r => !r.IsReturend).Select(r => r.CarId).ToList();

            cars = Controller<CarRentalManagementEntities, Car>.GetEntities
                (c => !carIds.Contains(c.CarId) && c.CarType.Type == comboBoxCarType.SelectedValue.ToString()).ToList();

            listBoxAvailableCars.DataSource = cars.Select(c=>c.Model).ToList();
            labelEstimatedPriceValue.Text = "";
        }

        private void fetchCustomers()
        {
            List<Customer> customers = Controller<CarRentalManagementEntities, Customer>.GetEntities().ToList();
            comboBoxCustomer.DataSource = customers;
        }

        private void listBoxAvailableCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selectedCar = cars[listBoxAvailableCars.SelectedIndex];
            labelEstimatedPriceValue.Text = selectedCar.Price.ToString();
        }

        private void comboBoxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAvailableCars();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer cust = (Customer) comboBoxCustomer.SelectedItem;
            List<int> reservationsData = Controller<CarRentalManagementEntities, Reservation>.
                GetEntities(r => !r.IsReturend && r.CustomerId == cust.CustomerId).Select(r=>r.CarId).ToList();

            List<Car> returnableCars = Controller<CarRentalManagementEntities, Car>.GetEntities(c => reservationsData.Contains(c.CarId)).ToList();
            if(returnableCars.Count > 0)
            {
                listBoxReturnCars.Visible = true;
                labelReturnCar.Visible = true;
                buttonReturnCar.Visible = true;
                listBoxReturnCars.DataSource = returnableCars;
            }
            else
            {
                listBoxReturnCars.Visible = false;
                labelReturnCar.Visible = false;
                buttonReturnCar.Visible = false;
            }
        }

        private void buttonRentCar_Click(object sender, EventArgs e)
        {
            if(dateTimePickerStartDate.Value < dateTimePickerEndDate.Value)
            {
                Reservation newReservation = new Reservation();
                newReservation.CarId = cars[listBoxAvailableCars.SelectedIndex].CarId;
                Customer cust = (Customer)comboBoxCustomer.SelectedItem;
                newReservation.CustomerId = cust.CustomerId;
                newReservation.StartDate = dateTimePickerStartDate.Value;
                newReservation.EndDate = dateTimePickerEndDate.Value;
                newReservation.IsReturend = false;
                Controller<CarRentalManagementEntities, Reservation>.AddEntity(newReservation);
                this.Close();
            }
        }

        private void buttonReturnCar_Click(object sender, EventArgs e)
        {
            Customer cust = (Customer)comboBoxCustomer.SelectedItem;
            Car car = (Car) listBoxReturnCars.SelectedItem;
            Reservation res = Controller<CarRentalManagementEntities, Reservation>.GetEntities(r => r.CarId == car.CarId && r.CustomerId == cust.CustomerId && !r.IsReturend).First();
            res.IsReturend = true;
            Controller<CarRentalManagementEntities, Reservation>.UpdateEntity(res);
            this.Close();
        }
    }
}
