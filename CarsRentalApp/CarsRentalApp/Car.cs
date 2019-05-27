using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRentalApp
{
    public class Car
    {
        private static int _idCount = 0;
        public static int IdCount { get {return _idCount;} set { _idCount = value; } }

        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _make;
        public string Make { get { return _make; } set { _make = value; } }

        private int _yearOfMake;
        public int YearOfMake { get { return _yearOfMake; } set { _yearOfMake = value; } }

        private string _model;
        public string Model { get { return _model; } set { _model = value; } }

        private bool _rented;
        public bool Rented { get { return _rented; } set { _rented = value; } }

        private int _doors;
        public int Doors { get { return _doors; } set { _doors = value; } }

        private string _transmission;
        public string Transmission { get { return _transmission; } set { _transmission = value; } }

        public Car(string name, string make, string model, int yearOfMake, int doors, string transmission)
        {
            _idCount++;
            _id = _idCount;
            _name = name;
            _make = make;
            _model = model;
            _yearOfMake = yearOfMake;
            _rented = false;
            _doors = doors;
            _transmission = transmission;


        }

        public void Rent()
        {
            //this.CustomerRenting = customer;
            this.Rented = true;
            Inventory.RentCar(this);
            //customer.Rent(this);
        }

        public override string ToString()
        {
            if (this.Rented == false)
            {
                return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, Not Rented\n", this.Id, this.Name,
                    this.Make, this.Model, this.YearOfMake, this.Doors, this.Transmission);
            }else
            {
                return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, Rented\n", this.Id, this.Name,
                    this.Make, this.Model, this.YearOfMake, this.Doors, this.Transmission);
            }
        }
    }
}
