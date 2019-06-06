namespace CarsRentalApp
{
    partial class NewMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainPage));
            this.ViewCarsButton = new System.Windows.Forms.Button();
            this.AddCarsButton = new System.Windows.Forms.Button();
            this.ViewCustomersButton = new System.Windows.Forms.Button();
            this.CarsIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CustomerIcon = new System.Windows.Forms.PictureBox();
            this.KeyIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RentIcon = new System.Windows.Forms.PictureBox();
            this.RentButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCarsButton
            // 
            this.ViewCarsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCarsButton.AutoSize = true;
            this.ViewCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCarsButton.Location = new System.Drawing.Point(244, 298);
            this.ViewCarsButton.Name = "ViewCarsButton";
            this.ViewCarsButton.Size = new System.Drawing.Size(125, 50);
            this.ViewCarsButton.TabIndex = 2;
            this.ViewCarsButton.Text = "Cars";
            this.ViewCarsButton.UseVisualStyleBackColor = true;
            this.ViewCarsButton.Click += new System.EventHandler(this.ViewCarsButton_Click);
            // 
            // AddCarsButton
            // 
            this.AddCarsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCarsButton.AutoSize = true;
            this.AddCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarsButton.Location = new System.Drawing.Point(516, 298);
            this.AddCarsButton.Name = "AddCarsButton";
            this.AddCarsButton.Size = new System.Drawing.Size(177, 50);
            this.AddCarsButton.TabIndex = 6;
            this.AddCarsButton.Text = "Add Cars";
            this.AddCarsButton.UseVisualStyleBackColor = true;
            this.AddCarsButton.Click += new System.EventHandler(this.AddCarsButton_Click);
            // 
            // ViewCustomersButton
            // 
            this.ViewCustomersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCustomersButton.AutoSize = true;
            this.ViewCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomersButton.Location = new System.Drawing.Point(806, 298);
            this.ViewCustomersButton.Name = "ViewCustomersButton";
            this.ViewCustomersButton.Size = new System.Drawing.Size(210, 50);
            this.ViewCustomersButton.TabIndex = 7;
            this.ViewCustomersButton.Text = "Customers";
            this.ViewCustomersButton.UseVisualStyleBackColor = true;
            this.ViewCustomersButton.Click += new System.EventHandler(this.ViewCustomersButton_Click);
            // 
            // CarsIcon
            // 
            this.CarsIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarsIcon.Image = ((System.Drawing.Image)(resources.GetObject("CarsIcon.Image")));
            this.CarsIcon.InitialImage = null;
            this.CarsIcon.Location = new System.Drawing.Point(220, 140);
            this.CarsIcon.Name = "CarsIcon";
            this.CarsIcon.Size = new System.Drawing.Size(175, 142);
            this.CarsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarsIcon.TabIndex = 8;
            this.CarsIcon.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-6, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(343, 128);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // CustomerIcon
            // 
            this.CustomerIcon.Image = ((System.Drawing.Image)(resources.GetObject("CustomerIcon.Image")));
            this.CustomerIcon.Location = new System.Drawing.Point(816, 144);
            this.CustomerIcon.Name = "CustomerIcon";
            this.CustomerIcon.Size = new System.Drawing.Size(175, 142);
            this.CustomerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerIcon.TabIndex = 10;
            this.CustomerIcon.TabStop = false;
            this.CustomerIcon.Click += new System.EventHandler(this.CustomerIcon_Click);
            // 
            // KeyIcon
            // 
            this.KeyIcon.Image = ((System.Drawing.Image)(resources.GetObject("KeyIcon.Image")));
            this.KeyIcon.Location = new System.Drawing.Point(206, 362);
            this.KeyIcon.Name = "KeyIcon";
            this.KeyIcon.Size = new System.Drawing.Size(208, 176);
            this.KeyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KeyIcon.TabIndex = 11;
            this.KeyIcon.TabStop = false;
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
            this.Title.Location = new System.Drawing.Point(403, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(759, 94);
            this.Title.TabIndex = 10;
            this.Title.Text = "Welcome To Car Rental";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 128);
            this.panel1.TabIndex = 12;
            // 
            // RentIcon
            // 
            this.RentIcon.Image = ((System.Drawing.Image)(resources.GetObject("RentIcon.Image")));
            this.RentIcon.Location = new System.Drawing.Point(515, 144);
            this.RentIcon.Name = "RentIcon";
            this.RentIcon.Size = new System.Drawing.Size(175, 142);
            this.RentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RentIcon.TabIndex = 13;
            this.RentIcon.TabStop = false;
            this.RentIcon.Click += new System.EventHandler(this.RentIcon_Click);
            // 
            // RentButton
            // 
            this.RentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentButton.AutoSize = true;
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.Location = new System.Drawing.Point(218, 536);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(177, 50);
            this.RentButton.TabIndex = 15;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(500, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewCustomerButton.AutoSize = true;
            this.NewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerButton.Location = new System.Drawing.Point(474, 536);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(265, 50);
            this.NewCustomerButton.TabIndex = 17;
            this.NewCustomerButton.Text = "New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // ExitIcon
            // 
            this.ExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExitIcon.Image")));
            this.ExitIcon.Location = new System.Drawing.Point(819, 390);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(172, 148);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitIcon.TabIndex = 19;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // NewMainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1269, 657);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.RentIcon);
            this.Controls.Add(this.KeyIcon);
            this.Controls.Add(this.AddCarsButton);
            this.Controls.Add(this.CarsIcon);
            this.Controls.Add(this.ViewCarsButton);
            this.Controls.Add(this.ViewCustomersButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerIcon);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewMainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rentals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewCarsButton;
        private System.Windows.Forms.Button AddCarsButton;
        private System.Windows.Forms.Button ViewCustomersButton;
        private System.Windows.Forms.PictureBox CarsIcon;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox KeyIcon;
        private System.Windows.Forms.PictureBox CustomerIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox RentIcon;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.PictureBox ExitIcon;
    }
}