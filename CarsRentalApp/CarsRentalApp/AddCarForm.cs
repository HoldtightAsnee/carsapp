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

    public partial class AddCarForm : Form
    {
        Car car;
        public Car Car { get { return car; } }
        string name;
        string make;
        string model;
        int yearOfMake;
        int doors;
        string transmission;
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "" | MakeTextBox.Text == "" | ModeltextBox.Text == "" | YearOfMaketextBox.Text == "" | DoorstextBox.Text == "" | TransmissionComboBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else
            { 
                car = new Car(name, make, model, yearOfMake, doors, transmission);
                Inventory.AddCar(car);
                this.Hide();
                ViewCars viewCars = new ViewCars();
                foreach (Car car in Inventory.Cars)
                {
                    viewCars.carItem = new ListViewItem(string.Format("{0}", car.Id));
                    viewCars.carItem.SubItems.Add(car.Name);
                    viewCars.carItem.SubItems.Add(car.Make);
                    viewCars.carItem.SubItems.Add(car.Model);
                    viewCars.carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                    viewCars.carItem.SubItems.Add(string.Format("{0}", car.Doors));
                    viewCars.carItem.SubItems.Add(car.Transmission);
                    viewCars.carItem.SubItems.Add(string.Format("{0}", car.Rented));
                    if (!viewCars.ListView1.Items.Contains(viewCars.carItem))
                    {
                        viewCars.ListView1.Items.Add(viewCars.carItem);
                    }

                }
                viewCars.Show();
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
            ViewCars viewCars = new ViewCars();
            foreach (Car car in Inventory.Cars)
            {
                viewCars.carItem = new ListViewItem(string.Format("{0}", car.Id));
                viewCars.carItem.SubItems.Add(car.Name);
                viewCars.carItem.SubItems.Add(car.Make);
                viewCars.carItem.SubItems.Add(car.Model);
                viewCars.carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                viewCars.carItem.SubItems.Add(string.Format("{0}", car.Doors));
                viewCars.carItem.SubItems.Add(car.Transmission);
                viewCars.carItem.SubItems.Add(string.Format("{0}", car.Rented));
                if (!viewCars.ListView1.Items.Contains(viewCars.carItem))
                {
                    viewCars.ListView1.Items.Add(viewCars.carItem);
                }

            }
            viewCars.Show();
            this.Hide();
        }
    }
}
