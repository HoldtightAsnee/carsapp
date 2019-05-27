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
    public partial class ViewCars : Form
    {
        public ListViewItem carItem;

        public void LoadData()
        {
            foreach (Car car in Inventory.Cars)
            {
                carItem = new ListViewItem(string.Format("{0}", car.Id));
                carItem.SubItems.Add(car.Name);
                carItem.SubItems.Add(car.Make);
                carItem.SubItems.Add(car.Model);
                carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                carItem.SubItems.Add(string.Format("{0}", car.Doors));
                carItem.SubItems.Add(car.Transmission);
                carItem.SubItems.Add(string.Format("{0}", car.Rented));
                if (!ListView1.Items.Contains(carItem))
                {
                    ListView1.Items.Add(carItem);
                }
            }
        }

        public ViewCars()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            this.Hide();
            addCarForm.Show();

        }


        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            try
            {

                List<Car> carsToRemove = new List<Car>();
                foreach (Car car in Inventory.Cars)
                {
                    if (car.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        carsToRemove.Add(car);
                    }
                }
                Inventory.RemoveCar(carsToRemove[0]);
                ListView1.Items.Clear();
                foreach (Car car in Inventory.Cars)
                {
                    carItem = new ListViewItem(string.Format("{0}", car.Id));
                    carItem.SubItems.Add(car.Name);
                    carItem.SubItems.Add(car.Make);
                    carItem.SubItems.Add(car.Model);
                    carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                    carItem.SubItems.Add(string.Format("{0}", car.Doors));
                    carItem.SubItems.Add(car.Transmission);
                    carItem.SubItems.Add(string.Format("{0}", car.Rented));
                    if (!ListView1.Items.Contains(carItem))
                    {
                        ListView1.Items.Add(carItem);
                    }

                }
            } catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select An Item");
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm();
                foreach (Car car in Inventory.Cars)
                {
                    if (car.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        editForm.CarsToEdit.Add(car);
                    }
                }
                editForm.NametextBox1.Text = editForm.CarsToEdit[0].Name;
                editForm.ModeltextBox1.Text = editForm.CarsToEdit[0].Model;
                editForm.MakeTextBox1.Text = editForm.CarsToEdit[0].Make;
                editForm.YearOfMaketextBox1.Text = string.Format("{0}", editForm.CarsToEdit[0].YearOfMake);
                editForm.DoorstextBox1.Text = string.Format("{0}", editForm.CarsToEdit[0].Doors);
                editForm.TransmissionComboBox1.Text = editForm.CarsToEdit[0].Transmission;
                this.Hide();
                editForm.Show();
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select an Item to edit");
            }

        }
    }

}
