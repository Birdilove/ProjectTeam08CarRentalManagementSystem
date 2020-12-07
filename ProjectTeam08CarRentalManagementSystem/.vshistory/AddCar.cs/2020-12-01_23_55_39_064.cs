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
    public partial class AddCar : Form
    {
        CarRentalManagementEntities context;
        public AddCar()
        {
            InitializeComponent();
            InitializeAddCar();
            buttonAddCar.Click += ButtonAddCar_Click;
            buttonCarMake.Click += ButtonCarMake_Click;
            buttonAddCarType.Click += ButtonAddCarType_Click;
        }

        private void ButtonAddCarType_Click(object sender, EventArgs e)
        {
            AddType carType = new AddType();
            carType.ShowDialog();
        }

        private void ButtonCarMake_Click(object sender, EventArgs e)
        {
            Add_Make addMake = new Add_Make();
            addMake.ShowDialog();
        }

        private void ButtonAddCar_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        public void InitializeAddCar()
        {
            context = new CarRentalManagementEntities();
            var carMakes = context.CarMakes.OrderBy(x => x.MakeId).Select(x => x.Make);
            var carType = context.CarTypes.OrderBy(x => x.TypeId).Select(x => x.Type);
            comboBoxCarMake.DataSource = carMakes.ToList();
            comboBoxCarType.DataSource = carType.ToList();
        }

        public void AddNewCar()
        {
            context = new CarRentalManagementEntities();
            var type = comboBoxCarType.Text;
            var typeId = context.CarTypes.Where(x => x.Type == type).Select(x => x.TypeId).Distinct();
            var make = comboBoxCarMake.Text;
            var makeId = context.CarMakes.Where(x => x.Make == make).Select(x => x.MakeId).Distinct();
            Car newCar = new Car()
            {
                TypeId = typeId.First(),
                MakeId = makeId.First(),
                Color = textBoxCarColor.Text,
                Model = textBoxCarModel.Text,
                Year = Int32.Parse(textBoxCarYear.Text),
                Price = Decimal.Parse(textBoxCarPrice.Text),
            };

            try
            {
                context.Cars.Add(newCar);
                context.SaveChanges();
                MessageBox.Show("Car added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add car to database" + ex.InnerException.InnerException.Message + "\n Make " + makeId.First());
                return;
            }
        }
    }
}
