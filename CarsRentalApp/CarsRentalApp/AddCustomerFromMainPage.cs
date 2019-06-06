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
    public partial class AddCustomerFromMainPage : Form
    {
        Customer customer;
        public Customer Customer { get { return customer; } }
        string firstName;
        string lastName;
        ViewCustomers viewCustomers;

        public AddCustomerFromMainPage()
        {
            InitializeComponent();

        }

        public AddCustomerFromMainPage(ViewCustomers view)
        {
            InitializeComponent();
            viewCustomers = view;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FirstNametextBox.Text == "" | LastNameTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else
            {
                customer = new Customer(firstName, lastName);
                CustomerList.AddCustomer(customer);
                this.Hide();
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            firstName = FirstNametextBox.Text;
        }

        private void MakeTextBox_TextChanged(object sender, EventArgs e)
        {
            lastName = LastNameTextBox.Text;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}