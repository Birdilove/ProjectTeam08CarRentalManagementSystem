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
using System.Data.Entity;


namespace ProjectTeam08CarRentalManagementSystem
{
    public partial class ViewReport : Form
    {
        private CarRentalManagementEntities context= new CarRentalManagementEntities();
        public ViewReport()
        {
            InitializeComponent();

            //load intial data from reservation data
            InitializeDataGridView();

            //set date range filter
            buttonDateFilter.Click += ButtonDateFilter_Click;
            //reset date range filter
            buttonResetFilter.Click += ButtonResetFilter_Click;
        }
        /// <summary>
        /// calculate total income using reservation and car data
        /// </summary>
        /// <param name="reservationList"></param>
        private void GetTotalIncome(Label label, List<Reservation> reservationList)
        {
            List<double> rentalPeriod = new List<double>();
            List<double> rentalPrice = new List<double>();
            double totalIncome = 0;

            //get date
            var start = reservationList.Select(r => r.StartDate).ToList();
            var end = reservationList.Select(r => r.EndDate).ToList();

            //get price
            var priceList = (from reservation in reservationList
                             join car in context.Cars on reservation.CarId equals car.CarId
                             select car.Price).ToList();
            //calculate rental period
            for (int idx = 0; idx < start.Count; idx++)
            {
                rentalPeriod.Add((end[idx] - start[idx]).TotalDays);
                rentalPrice.Add(rentalPeriod[idx] * Decimal.ToDouble(priceList[idx]));
                totalIncome += rentalPrice[idx];
            }
            
            label.Text = totalIncome.ToString("c");

        }

        /// <summary>
        /// Reset button to reset data range filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetFilter_Click(object sender, EventArgs e)
        {
            InitializeDataGridView();
            labelTotal.Text = "";
        }
        /// <summary>
        /// display list of reservation based on data range filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDateFilter_Click(object sender, EventArgs e)
        {
            //get data 
            var startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.ToShortDateString());
            var endDate = Convert.ToDateTime(dateTimePickerEndDate.Value.ToShortDateString());

            var reservationList = context.Reservations
                                    .Where(reservation => reservation.StartDate >= startDate &&
                                            reservation.EndDate <= endDate).ToList();

            //set returned car list
            var returnedCarList = reservationList.Where(r => r.IsReturend == true).ToList();
            SetDataGridView(dataGridViewReturnedCar,labelTotal, returnedCarList);
            //set not returned car list
            var notReturnedCarList = reservationList.Where(r => r.IsReturend == false).ToList();
            SetDataGridView(dataGridViewNotYetReturned, labelEstimatedTotal, notReturnedCarList);

        }
        /// <summary>
        /// initialize data gridview setting and load reservation data
        /// </summary>
        private void InitializeDataGridView()
        {
            //CarRentalManagementEntities context = new CarRentalManagementEntities();

            //initialize datagride view
            dataGridViewReturnedCar.AllowUserToAddRows = false;
            dataGridViewReturnedCar.AllowUserToDeleteRows = false;
            dataGridViewReturnedCar.ReadOnly = true;

            //get reservation data from entities
            context.Reservations.Load();
            //set returned car list
            var returnedCarList = context.Reservations.Where(r => r.IsReturend == true).ToList();
            SetDataGridView(dataGridViewReturnedCar,labelTotal, returnedCarList);
            //set not returned car list
            var notReturnedCarList = context.Reservations.Where(r => r.IsReturend == false).ToList();
            SetDataGridView(dataGridViewNotYetReturned,labelEstimatedTotal, notReturnedCarList);

        }

        /// <summary>
        /// set data gridview and load data
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="label"></param>
        /// <param name="reservationList"></param>
        private void SetDataGridView(DataGridView dataGridView, Label label, List<Reservation> reservationList)
        {
            dataGridView.DataSource = reservationList;
            dataGridView.Columns["Car"].Visible = false;
            dataGridView.Columns["Customer"].Visible = false;
            dataGridView.Columns["IsReturend"].Visible = false;

            //calculate total income
            GetTotalIncome(label, reservationList);
        }


    }
}
