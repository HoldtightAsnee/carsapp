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
        private static string _file = @"C:\Users\TJ\Desktop\CarsRentalApp\Inventory.txt";
        public static string File1 { get => _file; set => _file = value; }

        private static List<Car> _cars = new List<Car>();
        public static List<Car> Cars { get { return _cars; } }

        private static List<Car> _rentedCars = new List<Car>();
        public static List<Car> RentedCars { get { return _rentedCars; } }

        private static List<Car> _availableCars = new List<Car>();
        public static List<Car> AvailableCars { get { return _availableCars; } }



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
                try
                {
                    Car.IdCount = int.Parse(reader.ReadLine());
                } catch (ArgumentNullException f)
                {
                    Car.IdCount = 0;
                }
                while (!reader.EndOfStream)
                {
                    string carDetails = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(carDetails))
                    {
                        string[] carDetailsList = carDetails.Split(',');
                        for (int i = 0; i < carDetailsList.Length - 1; i++)
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
                                    if (carDetailsList[i].Contains("Not"))
                                    {
                                        rented = false;
                                    }
                                    else
                                    {
                                        rented = true;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        car = new Car(name, make, model, yearOfMake, doors, transmission);
                        if (rented)
                        {
                            car.Rented = rented;
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
    }
}