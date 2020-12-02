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
        public AddCar()
        {
            InitializeComponent();
            InitializeAddCar();
        }

        public void InitializeAddCar()
        {
            CarRentalManagementEntities context = new CarRentalManagementEntities();
            var carMakes = context.CarMakes.OrderBy(x => x.MakeId).Select(x => x.Make);
            var carType = context.CarTypes.OrderBy(x => x.TypeId).Select(x => x.Type);
            comboBoxCarMake.DataSource = carMakes.ToList();
            comboBoxCarType.DataSource = carType.ToList();
        }

        public void AddNewCar()
        {
            Car car = new Car()
            {
                Color = textBoxCarColor.Text,
                Model = textBoxCarModel.Text,
                Year = Int32.Parse(textBoxCarYear.Text),
                Price = Int32.Parse(textBoxCarPrice.Text),
            };
        }
    }
}
