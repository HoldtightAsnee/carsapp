using System.Windows.Forms;

namespace CarsRentalApp
{
    partial class RentCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCar));
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MakeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YOMColumumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoorsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransmissionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnButton = new System.Windows.Forms.Button();
            this.RentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SortOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(48, 220);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1157, 349);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 72;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 122;
            // 
            // MakeColumn
            // 
            this.MakeColumn.Text = "Make";
            this.MakeColumn.Width = 135;
            // 
            // ModelColumn
            // 
            this.ModelColumn.Text = "Model";
            this.ModelColumn.Width = 164;
            // 
            // YOMColumumn
            // 
            this.YOMColumumn.Text = "Year Of Make";
            this.YOMColumumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YOMColumumn.Width = 138;
            // 
            // DoorsColumn
            // 
            this.DoorsColumn.Text = "Doors";
            this.DoorsColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DoorsColumn.Width = 97;
            // 
            // TransmissionColumn
            // 
            this.TransmissionColumn.Text = "Transmission";
            this.TransmissionColumn.Width = 135;
            // 
            // RentedColumn
            // 
            this.RentedColumn.Text = "Customer Renting";
            this.RentedColumn.Width = 187;
            // 
            // ReturnButton
            // 
            this.ReturnButton.AutoSize = true;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(411, 586);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(124, 51);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Cancel";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RentButton
            // 
            this.RentButton.AutoSize = true;
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.Location = new System.Drawing.Point(557, 585);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(127, 53);
            this.RentButton.TabIndex = 7;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 128);
            this.panel1.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Impact", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(408, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(759, 94);
            this.Title.TabIndex = 10;
            this.Title.Text = "Welcome To Car Rental";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(343, 128);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(323, 160);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(212, 40);
            this.SearchTextBox.TabIndex = 15;
            this.SearchTextBox.Text = "Enter Details";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Make",
            "Model",
            "Year of Make",
            "Doors",
            "Transmisson",
            "Customer Renting"});
            this.SearchComboBox.Location = new System.Drawing.Point(48, 160);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(259, 41);
            this.SearchComboBox.TabIndex = 16;
            this.SearchComboBox.Text = "Search by category";
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // SortComboBox
            // 
            this.SortComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Make",
            "Model",
            "Year of Make",
            "Doors",
            "Transmission",
            "Customer Renting"});
            this.SortComboBox.Location = new System.Drawing.Point(735, 158);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(182, 41);
            this.SortComboBox.TabIndex = 17;
            this.SortComboBox.Text = "Sort By";
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // SortButton
            // 
            this.SortButton.AutoSize = true;
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(1094, 157);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(111, 42);
            this.SortButton.TabIndex = 18;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(557, 160);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 42);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(712, 585);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(135, 53);
            this.ResetButton.TabIndex = 20;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SortOrderCheckBox
            // 
            this.SortOrderCheckBox.AutoSize = true;
            this.SortOrderCheckBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortOrderCheckBox.Location = new System.Drawing.Point(941, 167);
            this.SortOrderCheckBox.Name = "SortOrderCheckBox";
            this.SortOrderCheckBox.Size = new System.Drawing.Size(147, 28);
            this.SortOrderCheckBox.TabIndex = 21;
            this.SortOrderCheckBox.Text = "Descending";
            this.SortOrderCheckBox.UseVisualStyleBackColor = true;
            this.SortOrderCheckBox.CheckedChanged += new System.EventHandler(this.SortOrderCheckBox_CheckedChanged);
            // 
            // RentCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1273, 661);
            this.Controls.Add(this.SortOrderCheckBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.listView1);
            this.Name = "RentCar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ListView ListView1 { get { return listView1; } set { listView1 = value; } }
        private ListView listView1;
        private ColumnHeader IDColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader MakeColumn;
        private ColumnHeader ModelColumn;
        private ColumnHeader YOMColumumn;
        private ColumnHeader DoorsColumn;
        private ColumnHeader TransmissionColumn;
        private ColumnHeader RentedColumn;
        private Button ReturnButton;
        private Button RentButton;
        private Panel panel1;
        private Label Title;
        private PictureBox Logo;
        private TextBox SearchTextBox;
        private ComboBox SearchComboBox;
        private ComboBox SortComboBox;
        private Button SortButton;
        private Button SearchButton;
        private Button ResetButton;
        private CheckBox SortOrderCheckBox;
    }
}