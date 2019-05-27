using System.Windows.Forms;

namespace CarsRentalApp
{
    partial class ViewCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCarButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MakeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YOMColumumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoorsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransmissionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveCarButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCarButton
            // 
            this.AddCarButton.AutoSize = true;
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(371, 354);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(146, 47);
            this.AddCarButton.TabIndex = 1;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn,
            this.MakeColumn,
            this.ModelColumn,
            this.YOMColumumn,
            this.DoorsColumn,
            this.TransmissionColumn,
            this.RentedColumn});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(913, 337);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 130;
            // 
            // MakeColumn
            // 
            this.MakeColumn.Text = "Make";
            // 
            // ModelColumn
            // 
            this.ModelColumn.Text = "Model";
            this.ModelColumn.Width = 96;
            // 
            // YOMColumumn
            // 
            this.YOMColumumn.Text = "Year Of Make";
            this.YOMColumumn.Width = 138;
            // 
            // DoorsColumn
            // 
            this.DoorsColumn.Text = "Doors";
            this.DoorsColumn.Width = 97;
            // 
            // TransmissionColumn
            // 
            this.TransmissionColumn.Text = "Transmission";
            this.TransmissionColumn.Width = 135;
            // 
            // RentedColumn
            // 
            this.RentedColumn.Text = "Rented";
            this.RentedColumn.Width = 95;
            // 
            // RemoveCarButton
            // 
            this.RemoveCarButton.AutoSize = true;
            this.RemoveCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCarButton.Location = new System.Drawing.Point(116, 354);
            this.RemoveCarButton.Name = "RemoveCarButton";
            this.RemoveCarButton.Size = new System.Drawing.Size(189, 47);
            this.RemoveCarButton.TabIndex = 4;
            this.RemoveCarButton.Text = " Remove Car";
            this.RemoveCarButton.UseVisualStyleBackColor = true;
            this.RemoveCarButton.Click += new System.EventHandler(this.RemoveCarButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(600, 354);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(189, 47);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ViewCars
            // 
            this.ClientSize = new System.Drawing.Size(913, 422);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveCarButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddCarButton);
            this.Name = "ViewCars";
            this.Text = "View Cars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ListView ListView1 { get { return listView1; } set { listView1 = value; } }
        private System.Windows.Forms.Button AddCarButton;
        private ListView listView1;
        private ColumnHeader IDColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader MakeColumn;
        private ColumnHeader ModelColumn;
        private ColumnHeader YOMColumumn;
        private ColumnHeader DoorsColumn;
        private ColumnHeader TransmissionColumn;
        private ColumnHeader RentedColumn;
        private Button RemoveCarButton;
        private Button EditButton;
    }
}