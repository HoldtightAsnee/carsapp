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
    public partial class CustomerSelection : Form
    {
        public ListViewItem customerItem;
        public List<Customer> customerReturning = new List<Customer>();
        string searchField;
        string details;
        string sortField;
        bool descending = false;

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
                        customerItem.SubItems.Add(string.Format("{0}", customer.Renting));
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

        public CustomerSelection()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortField = SortComboBox.Text;
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

        private void DescendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            descending = DescendingCheckBox.Checked;
        }
    }
}

