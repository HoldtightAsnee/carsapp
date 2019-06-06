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
    public partial class EditCustomerForm : Form
    {
        public List<Customer> CustomersToEdit { get => customersToEdit; set => customersToEdit = value; }
        Customer customer;
        public Customer Customer { get { return customer; } }
        string firstName;
        string lastName;
        ViewCustomers viewCustomers;
        List<Customer> customersToEdit = new List<Customer>();
        Customer oldCustomer;

        public EditCustomerForm()
        {
            InitializeComponent();
            viewCustomers.ListView1.Items.Clear();
        }

        public EditCustomerForm(ViewCustomers view)
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
                oldCustomer = CustomersToEdit[0];
                customer = new Customer(firstName, lastName, false);
                CustomerList.UpdateCustomer(oldCustomer, customer);
                viewCustomers.ListView1.Items.Clear();
                viewCustomers.LoadData();
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
            //viewCustomers.ListView1.Items.Clear();
            //viewCustomers.LoadData();
            this.Hide();
        }
    }
}
