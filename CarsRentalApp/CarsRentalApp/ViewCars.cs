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
        CustomerSelection viewCustomers = new CustomerSelection();
        List<Car> carsToRent = new List<Car>();
        CustomerInfoPopUp popUp = new CustomerInfoPopUp();
        string sortField;
        string searchField;
        string details;
        bool descending = false;

        public void LoadData()
        {
            if (ListView1.Items.Count == 0)
            {
                foreach (Car car in Inventory.Cars)
                {
                    bool unique = true;
                    carItem = new ListViewItem(string.Format("{0}", car.Id));
                    carItem.SubItems.Add(car.Name);
                    carItem.SubItems.Add(car.Make);
                    carItem.SubItems.Add(car.Model);
                    carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                    carItem.SubItems.Add(string.Format("{0}", car.Doors));
                    carItem.SubItems.Add(car.Transmission);
                    if (car.Rented)
                    {
                        carItem.SubItems.Add(string.Format("{0}", car.CustomerRenting.Id));
                    }
                    else
                    {
                        try
                        {

                            carItem.SubItems.Add(string.Format("{0}", car.CustomerRenting.Id));
                        }
                        catch (NullReferenceException f)
                        {
                            carItem.SubItems.Add("None");
                        }
                    }
                    foreach (var item in listView1.Items)
                    {
                        if (carItem.SubItems[0] == item)
                        {
                            unique = false;
                        }
                    }
                    if (unique)
                    {
                        ListView1.Items.Add(carItem);
                    }
                }
            }
        }

        public void LoadData(List<Car> carList)
        {
            if (ListView1.Items.Count == 0)
            {
                foreach (Car car in carList)
                {
                    bool unique = true;
                    carItem = new ListViewItem(string.Format("{0}", car.Id));
                    carItem.SubItems.Add(car.Name);
                    carItem.SubItems.Add(car.Make);
                    carItem.SubItems.Add(car.Model);
                    carItem.SubItems.Add(string.Format("{0}", car.YearOfMake));
                    carItem.SubItems.Add(string.Format("{0}", car.Doors));
                    carItem.SubItems.Add(car.Transmission);
                    if (car.Rented)
                    {
                        carItem.SubItems.Add(string.Format("{0}", car.CustomerRenting.Id));
                    }
                    else
                    {
                        try
                        {

                            carItem.SubItems.Add(string.Format("{0}", car.CustomerRenting.Id));
                        }
                        catch (NullReferenceException f)
                        {
                            carItem.SubItems.Add("None");
                        }
                    }
                    foreach (var item in listView1.Items)
                    {
                        if (carItem.SubItems[0] == item)
                        {
                            unique = false;
                        }
                    }
                    if (unique)
                    {
                        ListView1.Items.Add(carItem);
                    }
                }
            }
        }


        public ViewCars()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm(this);
            //this.Hide();
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
                this.LoadData();
            } catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select An Item");
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new EditForm(this);
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
                //this.Hide();
                editForm.Show();
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select an Item to edit");
            }

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            NewMainPage mainPage = new NewMainPage();
            this.Hide();
            mainPage.Show();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            try
            {
                carsToRent.Clear();
                //MessageBox.Show(ListView1.SelectedItems[0].SubItems[7].Text);
                foreach (Car car in Inventory.Cars)
                {
                    if (car.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        if (ListView1.SelectedItems[0].SubItems[7].Text != "None")
                        {
                            MessageBox.Show("The selected car has already been rented");
                            return;
                        }
                        else
                        {
                            carsToRent.Add(car);
                        }
                        
                    }
                }
                viewCustomers.ListView1.Items.Clear();
                viewCustomers.LoadData();
                viewCustomers.Show();
                viewCustomers.ListView1.ItemActivate += ListView1_ItemActivate;
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select a car to rent");
            }
        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            Customer rentingCustomer;
            string firstName = viewCustomers.ListView1.SelectedItems[0].SubItems[1].Text;
            string lastName = viewCustomers.ListView1.SelectedItems[0].SubItems[2].Text;
            rentingCustomer = new Customer(firstName, lastName, false);
            rentingCustomer.Id = int.Parse(viewCustomers.ListView1.SelectedItems[0].SubItems[0].Text);
            foreach (Customer customer in CustomerList.Customers)
            {
                if (rentingCustomer.Id == customer.Id)
                    {
                        carsToRent[0].Rent(customer);
                        customer.Rent(carsToRent[0]);
                    }
                
            }
            ListView1.Items.Clear();
            this.LoadData();
            viewCustomers.Hide();

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (descending)
                {
                    Inventory.SortByDescending(sortField);
                    listView1.Items.Clear();
                    this.LoadData(Inventory.SortedList);
                }
                else
                {
                    Inventory.SortByAscending(sortField);
                    listView1.Items.Clear();
                    this.LoadData(Inventory.SortedList);
                }
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show("Please select a category to sort by.");
            }
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortField = SortComboBox.Text;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.LoadData();
        }

        private void SortOrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            descending = SortOrderCheckBox.Checked;
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchField = SearchComboBox.Text;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            details = SearchTextBox.Text;
        }

       private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.UpdateSearchList(searchField, details);
                listView1.Items.Clear();
                this.LoadData(Inventory.SearchList);
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show("Please select a category to sort by.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RentalInfoButton_Click(object sender, EventArgs e)
        {
            if (!listView1.SelectedItems[0].SubItems[7].Text.Equals("None"))
            {
                foreach (Car car in Inventory.Cars)
                {
                    if (car.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text))
                    {
                        popUp.CarInfoLabel1.Text = car.CustomerRenting.Information();
                        popUp.ShowDialog();
                    }
                }
            }
            else
            {
                popUp.CarInfoLabel1.Text = "The selected car is \ncurrently not rented.";
                popUp.ShowDialog();
            }
        }
    }  
}