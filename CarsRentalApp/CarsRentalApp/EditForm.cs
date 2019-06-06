using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRentalApp
{
    public partial class EditForm : Form
    {
        Car car;
        public Car Car { get { return car; } }
        public List<Car> CarsToEdit { get => carsToEdit; set => carsToEdit = value; }
        string name;
        string make;
        string model;
        int yearOfMake;
        int doors;
        string transmission;
        ViewCars viewCars;
        List<Car> carsToEdit = new List<Car>();
        Car oldCar;

        public EditForm()
        {
            InitializeComponent();
            viewCars.ListView1.Items.Clear();
        }

        public EditForm(ViewCars view)
        {
            InitializeComponent();
            viewCars = view;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "" | MakeTextBox.Text == "" | ModeltextBox.Text == "" | YearOfMaketextBox.Text == "" | DoorstextBox.Text == "" | TransmissionComboBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else
            {
                oldCar = CarsToEdit[0];
                car = new Car(name, make, model, yearOfMake, doors, transmission);
                Inventory.UpdateCar(oldCar, car);
                viewCars.ListView1.Items.Clear();
                viewCars.LoadData();
                this.Hide();
            }
        }



        private void ModeltextBox_TextChanged(object sender, EventArgs e)
        {
            model = ModeltextBox.Text;
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            name = NametextBox.Text;
        }

        private void MakeTextBox_TextChanged(object sender, EventArgs e)
        {
            make = MakeTextBox.Text;
        }

        private void YearOfMaketextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearOfMake = int.Parse(YearOfMaketextBox.Text);
            }
            catch (FormatException f)
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void DoorstextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doors = int.Parse(DoorstextBox.Text);
            }
            catch (FormatException f)
            {
                MessageBox.Show("Please Enter A number");
            }
        }


        private void TransmissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transmission = TransmissionComboBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //viewCars.LoadData();
            this.Hide();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CarsToEdit[0].ToString());
        }
    }

}
