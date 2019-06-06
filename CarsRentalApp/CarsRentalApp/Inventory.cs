using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarsRentalApp
{
    public class Inventory
    {
        private static string _file = @"C:\Users\TJ\Documents\CarsRentalApp\Inventory.txt";
        public static string File1 { get => _file; set => _file = value; }

        private static List<Car> _cars = new List<Car>();
        public static List<Car> Cars { get { return _cars; } }

        private static List<Car> _rentedCars = new List<Car>();
        public static List<Car> RentedCars { get { return _rentedCars; } }

        private static List<Car> _availableCars = new List<Car>();
        public static List<Car> AvailableCars { get { return _availableCars; } }

        public static List<int> CustomerIds = new List<int>();

        private static List<Car> _sortedList;
        public static List<Car> SortedList { get { return _sortedList; } set { _sortedList = value; } }

        private static List<Car> _searchList = new List<Car>();
        public static List<Car> SearchList { get { return _searchList; } set { _searchList = value; } }


        public static void AddCar(Car car)
        {
            _cars.Add(car);
            _availableCars.Add(car);
            UpdateInvetoryFile(Cars, false);
        }

        public static void RemoveCar(Car car)
        {
            Cars.Remove(car);
            if (car.Rented)
            {
                RentedCars.Remove(car);
            }
            else
            {
                AvailableCars.Remove(car);
            }
            UpdateInvetoryFile(Cars, false);
        }

        public static void UpdateCar(Car carToUpdate, Car carWithDetails)
        {
            carWithDetails.Id = carToUpdate.Id;
            carToUpdate.Name = carWithDetails.Name;
            carToUpdate.Model = carWithDetails.Model;
            carToUpdate.Make = carWithDetails.Make;
            carToUpdate.YearOfMake = carWithDetails.YearOfMake;
            carToUpdate.Doors = carWithDetails.Doors;
            carToUpdate.Transmission = carWithDetails.Transmission;

            UpdateInvetoryFile(Cars, false);
        }

        public static void RentCar(Car car)
        {
            _rentedCars.Add(car);
            _availableCars.Remove(car);
            UpdateInvetoryFile(Cars, false);
        }

        public static void RecieveRentedCar(Car car)
        {
            _rentedCars.Remove(car);
            _availableCars.Add(car);
        }

        public static string DisplayCarsInventory()
        {
            string cars = "";
            foreach (Car car in Cars)
            {
                cars += car.ToString();
                cars += "\n";
            }
            return cars;
        }

        public static string DisplayRentedCarsInventory()
        {
            string cars = "";
            foreach (Car car in RentedCars)
            {
                cars += car.ToString() + "\n";
            }
            return cars;
        }

        public static string DisplayAvailableCarsInventory()
        {
            string cars = "";
            foreach (Car car in AvailableCars)
            {
                cars += car.ToString() + "\n";
            }
            return cars;
        }

        public static string DisplayFullInventory()
        {
            return string.Format("CARS\n{0}\nRENTED CARS\n{1}\nAVAILABLE CARS\n{2}", DisplayCarsInventory(), DisplayRentedCarsInventory(), DisplayAvailableCarsInventory());
        }

        public static void UpdateInvetoryFile(List<Car> carsList, bool append)
        {
            string cars = "";
            StreamWriter writer = new StreamWriter(_file, append);
            writer.WriteLine(Car.IdCount);
            foreach (Car car in carsList)
            {
                cars += car.ToString();
                cars += "\n";
            }
            writer.Write(cars);
            writer.Close();
        }

        public static void UpdateInvetoryFromFile()
        {
            if (File.Exists(File1))
            {

                StreamReader reader = new StreamReader(_file);
                int id = 0;
                string name = "";
                string model = "";
                string make = "";
                int yearOfMake = 0;
                int doors = 0;
                string transmission = "";
                bool rented = false;
                Car car;
                int customerId = 0;
                try
                {
                    Car.IdCount = int.Parse(reader.ReadLine());
                }
                catch (ArgumentNullException f)
                {
                    Car.IdCount = 0;
                }
                while (!reader.EndOfStream)
                {
                    string carDetails = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(carDetails))
                    {
                        string[] carDetailsList = carDetails.Split(',');
                        for (int i = 0; i < carDetailsList.Length; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    id = int.Parse(carDetailsList[i]);
                                    break;
                                case 1:
                                    name = carDetailsList[i].Trim();
                                    break;
                                case 2:
                                    make = carDetailsList[i].Trim();
                                    break;
                                case 3:
                                    model = carDetailsList[i].Trim();
                                    break;
                                case 4:
                                    yearOfMake = int.Parse(carDetailsList[i].Trim());
                                    break;
                                case 5:
                                    doors = int.Parse(carDetailsList[i].Trim());
                                    break;
                                case 6:
                                    transmission = carDetailsList[i].Trim();
                                    break;
                                case 7:
                                    if (!carDetailsList[i].Contains("Not"))
                                    {
                                        rented = true;
                                        CustomerIds.Add(int.Parse(carDetailsList[i].Trim()));

                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        car = new Car(name, make, model, yearOfMake, doors, transmission, false);
                        if (rented)
                        {
                            RentedCars.Add(car);
                        }
                        car.Id = id;
                        UpdateInventory(car);
                        carDetails = reader.ReadLine();
                    }
                }
                reader.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public static void UpdateInventory(Car car)
        {
            Inventory.Cars.Add(car);
            if (car.Rented)
            {
                Inventory.RentedCars.Add(car);
            }
            else
            {
                Inventory.AvailableCars.Add(car);
            }
        }

        public static void UpdateRentalInfo()
        {
            for (int i = 0; i < RentedCars.Count; i++)
            {
                foreach (Customer customer in CustomerList.RentingCustomers)
                {
                    try
                    {
                        if (CustomerIds[i] == customer.Id)
                        {
                            RentedCars[i].Rent(customer);
                        }
                    }
                    catch (IndexOutOfRangeException f)
                    {
                        break;
                    }
                    catch (ArgumentOutOfRangeException f)
                    {
                        break;
                    }
                }
                UpdateInvetoryFile(Cars, false);
            }
        }

        public static void SortByAscending(string field)
        {
            Car temp;
            SortedList = new List<Car>(Cars);
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
            else if (field.Equals("Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Name, SortedList[i + 1].Name) > 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Make"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Make, SortedList[i + 1].Make) > 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Model"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Model, SortedList[i + 1].Model) > 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Year of Make"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].YearOfMake > SortedList[i + 1].YearOfMake)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Doors"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].Doors > SortedList[i + 1].Doors)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Transmission"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Transmission, SortedList[i + 1].Transmission) > 0)
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
            Car temp;
            SortedList = new List<Car>(Cars);
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
            else if (field.Equals("Name"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Name, SortedList[i + 1].Name) < 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Make"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Make, SortedList[i + 1].Make) < 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Model"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Model, SortedList[i + 1].Model) < 0)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Year of Make"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].YearOfMake < SortedList[i + 1].YearOfMake)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Doors"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (SortedList[i].Doors < SortedList[i + 1].Doors)
                        {
                            temp = SortedList[i + 1];
                            SortedList[i + 1] = SortedList[i];
                            SortedList[i] = temp;
                        }
                    }
                }
            }
            else if (field.Equals("Transmission"))
            {
                for (int j = 0; j <= SortedList.Count - 2; j++)
                {
                    for (int i = 0; i <= SortedList.Count - 2; i++)
                    {
                        if (string.Compare(SortedList[i].Transmission, SortedList[i + 1].Transmission) < 0)
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
                foreach(Car car in Cars)
                {
                    if (car.Id == int.Parse(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Name"))
            {
                foreach(Car car in Cars)
                {
                    if (car.Name.Contains(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Make"))
            {
                foreach (Car car in Cars)
                {
                    if (car.Make.Contains(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Model"))
            {
                foreach (Car car in Cars)
                {
                    if (car.Model.Contains(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Year of Make"))
            {
                foreach (Car car in Cars)
                {
                    if (car.YearOfMake == int.Parse(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Doors"))
            {
                foreach (Car car in Cars)
                {
                    if (car.YearOfMake == int.Parse(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
            else if (field.Equals("Transmission"))
            {
                foreach (Car car in Cars)
                {
                    if (car.Transmission.Contains(value))
                    {
                        SearchList.Add(car);
                    }
                }
            }
        }
    }
}