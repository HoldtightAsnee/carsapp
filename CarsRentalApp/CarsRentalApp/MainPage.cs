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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            try
            {
                Inventory.UpdateInvetoryFromFile();
            }
            catch (FileNotFoundException e)
            {
                //PathForm path = new PathForm();
                //this.Hide();
                //path.Show();
               File.Create(@"C:\Users\TJ\Desktop\CarsRentalApp\Inventory.txt");

            }
        }


        private void ViewCarsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCars viewCars = new ViewCars();
            viewCars.LoadData();
            viewCars.Show();
        }

        private void AddCarsButton_Click(object sender, EventArgs e)
        {
            AddCarFromMainPage addCar = new AddCarFromMainPage();
            addCar.Show();
        }
    }
}
