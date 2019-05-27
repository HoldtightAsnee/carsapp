namespace CarsRentalApp
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewCarsButton = new System.Windows.Forms.Button();
            this.AddCarsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Car Rentals";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(767, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select an option from below";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewCarsButton
            // 
            this.ViewCarsButton.AutoSize = true;
            this.ViewCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCarsButton.Location = new System.Drawing.Point(410, 360);
            this.ViewCarsButton.Name = "ViewCarsButton";
            this.ViewCarsButton.Size = new System.Drawing.Size(191, 50);
            this.ViewCarsButton.TabIndex = 2;
            this.ViewCarsButton.Text = "View Cars";
            this.ViewCarsButton.UseVisualStyleBackColor = true;
            this.ViewCarsButton.Click += new System.EventHandler(this.ViewCarsButton_Click);
            // 
            // AddCarsButton
            // 
            this.AddCarsButton.AutoSize = true;
            this.AddCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarsButton.Location = new System.Drawing.Point(410, 284);
            this.AddCarsButton.Name = "AddCarsButton";
            this.AddCarsButton.Size = new System.Drawing.Size(177, 50);
            this.AddCarsButton.TabIndex = 6;
            this.AddCarsButton.Text = "Add Cars";
            this.AddCarsButton.UseVisualStyleBackColor = true;
            this.AddCarsButton.Click += new System.EventHandler(this.AddCarsButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 678);
            this.Controls.Add(this.AddCarsButton);
            this.Controls.Add(this.ViewCarsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewCarsButton;
        private System.Windows.Forms.Button AddCarsButton;
    }
}