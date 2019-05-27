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
    public partial class PathForm : Form
    {
        public PathForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            try
            {
              FileAttributes attr = File.GetAttributes(Inventory.File1);
              if (attr.HasFlag(FileAttributes.Directory))
              {
                  Inventory.File1 += "\\inventory.txt";
              }
              this.Hide();
              mainPage.Show();
            } 
            catch (FileNotFoundException f)
            {
               MessageBox.Show("Please Enter A valid File Path");
                this.Hide();
            }catch (NotSupportedException f)
            {
              MessageBox.Show("Please Enter A valid File Path\n");
              
            }
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            Inventory.File1 = FilePathTextBox.Text;
        }

    }
}
