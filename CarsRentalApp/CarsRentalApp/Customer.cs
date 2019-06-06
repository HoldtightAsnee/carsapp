using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRentalApp
{
    public class Customer
    {
        private static int _idCount = 0;
        public static int IdCount { get => _idCount; set => _idCount = value; }

        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        private bool _renting;
        public bool Renting { get { return _renting; } set { _renting = value; } }

        private Car _carRented;
        public Car CarRented { get { return _carRented; } set { _carRented = value; } }

        private List<Car> _carsRented = new List<Car>();
        public List<Car> CarsRented { get { return _carsRented; } }



        public Customer(string fname, string lname, bool addIdCount = true)
        {
            if (addIdCount)
            {
                _idCount++;
            }
            _id = +IdCount;
            _firstName = fname;
            _lastName = lname;
            _renting = false;
        }

        public void Rent(Car car)
        {
            _carRented = car;
            _carsRented.Add(car);
            _renting = true;
            CustomerList.UpdateCustomersFile(CustomerList.Customers, false);
        }

        public void ReturnCar(Car car)
        {
            _carRented = null;
            _renting = false;
            CustomerList.UpdateCustomersFile(CustomerList.Customers, false);
        }

        public string DisplayCarsRented()
        {
            string cars = "";
            foreach  (Car car in CarsRented )
            {
                cars += car.ToString();
            }
            return cars;
        }

        public override string ToString()
        {
            if (Renting)
            {
                return string.Format("{0}, {1}, {2}, {3}\n", Id, FirstName, LastName,
                    CarRented.Id);
            }
            else
            {
                return string.Format("{0}, {1}, {2}, Not Renting\n", Id, FirstName, LastName);
            }

        }

        public string Information()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
