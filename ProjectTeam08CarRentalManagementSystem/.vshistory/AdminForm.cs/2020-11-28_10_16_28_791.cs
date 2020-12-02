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
    public partial class Form1 : Form
    {
        CarRentalManagementEntities context;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeStudentRegistrationFormsAppMainForm()
        {
             CarRentalManagementEntities context = new CarRentalManagementEntities();
            //context.SeedDatabase();

            //Calling method that initializes all of the datagrids.
            InitializeDataGridView<Reservation>(dataGridViewRentedCars);
        }

        private void InitializeDataGridView<T>(DataGridView datagridView) where T : class
        {
            datagridView.AllowUserToAddRows = false;
            datagridView.AllowUserToDeleteRows = true;
            datagridView.ReadOnly = true;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView.DataSource = context.Reservations.To

            var registrations = (from student in context.Reservations
                                 from course in student.Courses
                                 select new
                                 {
                                     student.Department.DepartmentCode,
                                     CouseNumber = course.CourseNumber,
                                     course.CourseName,
                                     student.StudentId,
                                     student.StudentLastName
                                 }).ToList();

        }

    }
}
