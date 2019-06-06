using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarsRentalApp
{
    class CustomerList
    {
        private static string _file = @"C:\Users\TJ\Documents\CarsRentalApp\Customers.txt";
        public static string File1 { get => _file; set => _file = value; }

        private static List<Customer> _customers = new List<Customer>();
        public static List<Customer> Customers { get => _customers; set => _customers = value; }

        private static List<Customer> _rentingCustomers = new List<Customer>();
        public static List<Customer> RentingCustomers { get => _rentingCustomers; set => _rentingCustomers = value; }

        private static List<Customer> _sortedList;
        public static List<Customer> SortedList { get { return _sortedList; } set { _sortedList = value; } }

        private static List<Customer> _searchList = new List<Customer>();
        public static List<Customer> SearchList { get { return _searchList; } set { _searchList = value; } }

        public static List<int> CarIds = new List<int>();

        public static void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            UpdateCustomersFile(_customers, false);
        }

        public static void RemoveCustomer(Customer customer)
        {
            _customers.Remove(customer);
            if (customer.Renting)
            {
                _rentingCustomers.Remove(customer);
            }
            UpdateCustomersFile(_customers, false);
        }

        public static void UpdateCustomer(Customer customerToUpdate, Customer customerWithDetails)
        {
            customerWithDetails.Id = customerToUpdate.Id;
            customerToUpdate.FirstName = customerWithDetails.FirstName;
            customerToUpdate.LastName = customerWithDetails.LastName;
            customerToUpdate.Renting = customerWithDetails.Renting;
            customerToUpdate.CarRented = customerWithDetails.CarRented;

            UpdateCustomersFile(_customers, false);
        }

        public static void Rent(Customer customer)
        {
            _rentingCustomers.Add(customer);
        }

        public static string DisplayCustomers()
        {
            string customersString = "";
            foreach (Customer customer in _customers)
            {
                customersString += customer.ToString();
                customersString += "\n";
            }
            return customersString;
        }

        public static string DisplayRentingCustomers()
        {
            string customersString = "";
            foreach (Customer customer in _rentingCustomers)
            {
                customersString += customer.ToString();
                customersString += "\n";
            }
            return customersString;
        }

        public static void UpdateCustomersFile(List<Customer> customers, bool append)
        {
            string customersString = "";
            StreamWriter writer = new StreamWriter(_file, append);
            writer.WriteLine(Customer.IdCount);
            foreach (Customer customer in customers)
            {
                customersString += customer.ToString();
                customersString += "\n";
            }
            writer.Write(customersString);
            writer.Close();
        }

        public static void UpdateCustomersFromFile()
        {
            if (File.Exists(_file))
            {
                StreamReader reader = new StreamReader(_file);
                int id = 0;
                string firstName = "";
                string lastName = "";
                int carRentingId = 0;
                bool renting = false;
                Customer customer;
                try
                {
                    Customer.IdCount = int.Parse(reader.ReadLine());
                }
                catch (ArgumentNullException f)
                {
                    Customer.IdCount = 0;
                }
                while (!reader.EndOfStream)
                {
                    string customerDetails = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(customerDetails))
                    {
                        string[] customerDetailsList = customerDetails.Split(',');
                        for (int i = 0; i < customerDetailsList.Length; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    id = int.Parse(customerDetailsList[i]);
                                    break;
                                case 1:
                                    firstName = customerDetailsList[i].Trim();
                                    break;
                                case 2:
                                    lastName = customerDetailsList[i].Trim();
                                    break;
                                case 3:
                                    if (customerDetailsList[i].Contains("Not"))
                                    {
                                        renting = false;
                                    }
                                    else
                                    {
                                        renting = true;
                                        CarIds.Add(int.Parse(customerDetailsList[i]));
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        customer = new Customer(firstName, lastName, false);
                        if (renting)
                        {
                            RentingCustomers.Add(customer);
                        }
                        customer.Id = id;
                        UpdateCustomers(customer);
                        customerDetails = reader.ReadLine();
                    }
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public static void UpdateCustomers(Customer customer)
        {
            Customers.Add(customer);
            if (customer.Renting)
            {
                _rentingCustomers.Add(customer);
            }
        }

        public static void UpdateRentalInfo()
        {
            for (int i = 0; i < RentingCustomers.Count; i++)
            {
                foreach (Car car in Inventory.RentedCars)
                {
                    if (CarIds[i] == car.Id)
                    {
                        RentingCustomers[i].Rent(car);
                    }
                }
            }
            UpdateCustomersFile(Customers, false);
        }

        public static void SortByAscending(string field)
        {
            Customer temp;
            SortedList = new List<Customer>(Customers);
            if (field.Equals("ID"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].Id > SortedList[i + 1].Id)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("First Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].FirstName, SortedList[i + 1].FirstName) > 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Last Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].LastName, SortedList[i + 1].LastName) > 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }



        }

        public static void SortByDescending(string field)
        {
            Customer temp;
            SortedList = new List<Customer>(Customers);
            if (field.Equals("ID"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].Id < SortedList[i + 1].Id)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("First Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].FirstName, SortedList[i + 1].FirstName) < 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Last Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].LastName, SortedList[i + 1].LastName) < 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
        }

        public static void UpdateSearchList(string field, string value)
        {
            SearchList.Clear();
            if (field.Equals("ID"))
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.Id == int.Parse(value))
                    {
                        SearchList.Add(customer);
                    }
                }
            }
            else if (field.Equals("First Name"))
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.FirstName.Contains(value))
                    {
                        SearchList.Add(customer);
                    }
                }
            }
            else if (field.Equals("Last Name"))
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.LastName.Contains(value))
                    {
                        SearchList.Add(customer);
                    }
                }
            }
        }
    }
}