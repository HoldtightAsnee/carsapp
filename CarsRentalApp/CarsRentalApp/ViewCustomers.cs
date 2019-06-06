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
    public partial class ViewCustomers : Form
    {
        public ListViewItem customerItem;
        public List<Customer> customerReturning = new List<Customer>();
        CarInfoPopup popUp = new CarInfoPopup();
        bool descending = false;
        string searchField;
        string details;
        string sortField;

        public void LoadData()
        {
            if (ListView1.Items.Count == 0)
            {
                foreach (Customer customer in CustomerList.Customers)
                {
                    bool unique = true;
                    customerItem = new ListViewItem(string.Format("{0}", customer.Id));
                    customerItem.SubItems.Add(customer.FirstName);
                    customerItem.SubItems.Add(customer.LastName);
                    if (customer.Renting)
                    {
                        customerItem.SubItems.Add(string.Format("{0}", customer.CarRented.Id));
                    }
                    else
                    {
                        customerItem.SubItems.Add("None");
                    }
                    foreach (var item in listView1.Items)
                    {
                        if (customerItem.SubItems[0] == item)
                        {
                            unique = false;
                        }
                    }
                    if (unique)
                    {
                        ListView1.Items.Add(customerItem);
                    }
                }
            }
        }

        public void LoadData(List<Customer> customerList)
        {
            if (ListView1.Items.Count == 0)
            {
                foreach (Customer customer in customerList)
                {
                    bool unique = true;
                    customerItem = new ListViewItem(string.Format("{0}", customer.Id));
                    customerItem.SubItems.Add(customer.FirstName);
                    customerItem.SubItems.Add(customer.LastName);
                    if (customer.Renting)
                    {
                        customerItem.SubItems.Add(string.Format("{0}", customer.CarRented.Id));
                    }
                    else
                    {
                        customerItem.SubItems.Add("None");
                    }
                    foreach (var item in listView1.Items)
                    {
                        if (customerItem.SubItems[0] == item)
                        {
                            unique = false;
                        }
                    }
                    if (unique)
                    {
                        ListView1.Items.Add(customerItem);
                    }
                }
            }
        }

        public ViewCustomers()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(this);
            addCustomerForm.Show();

        }


        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            try
            {

                List<Customer> customersToRemove = new List<Customer>();
                foreach (Customer customer in CustomerList.Customers)
                {
                    if (customer.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        customersToRemove.Add(customer);
                    }
                }
                CustomerList.RemoveCustomer(customersToRemove[0]);
                ListView1.Items.Clear();
                this.LoadData();
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select An Item");
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditCustomerForm editForm = new EditCustomerForm(this);
                foreach (Customer customer in CustomerList.Customers)
                {
                    if (customer.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        editForm.CustomersToEdit.Add(customer);
                    }
                }
                editForm.NametextBox1.Text = editForm.CustomersToEdit[0].FirstName;
                editForm.MakeTextBox1.Text = editForm.CustomersToEdit[0].LastName;
                editForm.Show();
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select an Item to edit");
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NewMainPage mainPage = new NewMainPage();
            this.Hide();
            mainPage.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int returningCarId = 0;
            Car carBeingReturned;
            try
            {

                foreach (Customer customer in CustomerList.Customers)
                {
                    if (customer.Id == int.Parse(ListView1.SelectedItems[0].SubItems[0].Text))
                    {
                        if (customer.Renting)
                        {
                            customerReturning.Add(customer);
                            returningCarId = int.Parse(ListView1.SelectedItems[0].SubItems[3].Text);
                        }
                        else
                        {
                            MessageBox.Show("The selected customer is currently not renting");
                        }
                    }

                }
                if (!(returningCarId == 0))
                {
                    foreach (Car car in Inventory.Cars)
                    {
                        if (returningCarId == car.Id)
                        {
                            //carBeingReturned = car;
                            //carBeingReturned.Return();
                            car.Return();
                            customerReturning[0].ReturnCar(car);
                        }
                    }
                    customerReturning.Clear();
                    ListView1.Items.Clear();
                    this.LoadData();
                }
            }
            catch (ArgumentOutOfRangeException f)
            {
                MessageBox.Show("Please Select a customer");
            }
        }

        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            descending = DescendingCheckBox.Checked;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (descending)
                {
                    CustomerList.SortByDescending(sortField);
                    listView1.Items.Clear();
                    this.LoadData(CustomerList.SortedList);
                }
                else
                {
                    CustomerList.SortByAscending(sortField);
                    listView1.Items.Clear();
                    this.LoadData(CustomerList.SortedList);
                }
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show("Please select a category to sort by.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.LoadData();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortField = SortComboBox.Text;
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
                CustomerList.UpdateSearchList(searchField, details);
                listView1.Items.Clear();
                this.LoadData(CustomerList.SearchList);
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show("Please select a category to sort by.");
            }
        }

        private void RentalInfoButton_Click(object sender, EventArgs e)
        {
            if (!listView1.SelectedItems[0].SubItems[3].Text.Equals("None"))
            {
                foreach (Customer customer in CustomerList.Customers)
                {
                    if (customer.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text))
                    {
                        popUp.CarInfoLabel1.Text = customer.CarRented.Information();
                        popUp.ShowDialog();
                    }
                }
            }
            else
            {
                popUp.CarInfoLabel1.Text = "The selected customer is \ncurrently not renting a car.";
                popUp.ShowDialog();
            }
        }
    }
}

