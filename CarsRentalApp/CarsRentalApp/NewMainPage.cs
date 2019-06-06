using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarsRentalApp
{
    public partial class NewMainPage : Form
    {
        public NewMainPage()
            {
                InitializeComponent();
            }


            private void ViewCarsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCars viewCars = new ViewCars();
            viewCars.Show();
        }

        private void AddCarsButton_Click(object sender, EventArgs e)
        {
            AddCarFromMainPage addCar = new AddCarFromMainPage();
            addCar.Show();
        }

        private void ViewCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomers viewCustomers = new ViewCustomers();
            viewCustomers.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerFromMainPage addCustomer = new AddCustomerFromMainPage();
            addCustomer.Show();
        }

        private void RentIcon_Click(object sender, EventArgs e)
        {

        }

        private void CustomerIcon_Click(object sender, EventArgs e)
        {

        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            RentCar rentPage = new RentCar();
            rentPage.Show();
        }
    }
}
