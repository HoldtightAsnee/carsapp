using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace CarsRentalApp
{
    partial class EditForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.DoorstextBox = new System.Windows.Forms.TextBox();
            this.YearOfMaketextBox = new System.Windows.Forms.TextBox();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.Transmission = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.YearOfMakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ChangButton = new System.Windows.Forms.Button();
            this.TransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(63, 71);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(150, 65);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 26);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // DoorstextBox
            // 
            this.DoorstextBox.Location = new System.Drawing.Point(150, 286);
            this.DoorstextBox.Name = "DoorstextBox";
            this.DoorstextBox.Size = new System.Drawing.Size(100, 26);
            this.DoorstextBox.TabIndex = 3;
            this.DoorstextBox.TextChanged += new System.EventHandler(this.DoorstextBox_TextChanged);
            // 
            // YearOfMaketextBox
            // 
            this.YearOfMaketextBox.Location = new System.Drawing.Point(150, 229);
            this.YearOfMaketextBox.Name = "YearOfMaketextBox";
            this.YearOfMaketextBox.Size = new System.Drawing.Size(100, 26);
            this.YearOfMaketextBox.TabIndex = 4;
            this.YearOfMaketextBox.TextChanged += new System.EventHandler(this.YearOfMaketextBox_TextChanged);
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(150, 178);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(100, 26);
            this.ModeltextBox.TabIndex = 5;
            this.ModeltextBox.TextChanged += new System.EventHandler(this.ModeltextBox_TextChanged);
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(150, 123);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(100, 26);
            this.MakeTextBox.TabIndex = 6;
            this.MakeTextBox.TextChanged += new System.EventHandler(this.MakeTextBox_TextChanged);
            // 
            // Transmission
            // 
            this.Transmission.AutoSize = true;
            this.Transmission.Location = new System.Drawing.Point(33, 336);
            this.Transmission.Name = "Transmission";
            this.Transmission.Size = new System.Drawing.Size(102, 20);
            this.Transmission.TabIndex = 9;
            this.Transmission.Text = "Transmission";
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Location = new System.Drawing.Point(63, 286);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(52, 20);
            this.DoorsLabel.TabIndex = 10;
            this.DoorsLabel.Text = "Doors";
            // 
            // YearOfMakeLabel
            // 
            this.YearOfMakeLabel.AutoSize = true;
            this.YearOfMakeLabel.Location = new System.Drawing.Point(28, 235);
            this.YearOfMakeLabel.Name = "YearOfMakeLabel";
            this.YearOfMakeLabel.Size = new System.Drawing.Size(107, 20);
            this.YearOfMakeLabel.TabIndex = 11;
            this.YearOfMakeLabel.Text = "Year Of Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(63, 178);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 12;
            this.ModelLabel.Text = "Model";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(63, 123);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(48, 20);
            this.MakeLabel.TabIndex = 13;
            this.MakeLabel.Text = "Make";
            // 
            // ChangButton
            // 
            this.ChangButton.AutoSize = true;
            this.ChangButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangButton.Location = new System.Drawing.Point(204, 393);
            this.ChangButton.Name = "ChangButton";
            this.ChangButton.Size = new System.Drawing.Size(121, 45);
            this.ChangButton.TabIndex = 14;
            this.ChangButton.Text = "Change";
            this.ChangButton.UseVisualStyleBackColor = true;
            this.ChangButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TransmissionComboBox
            // 
            this.TransmissionComboBox.FormattingEnabled = true;
            this.TransmissionComboBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransmissionComboBox.Location = new System.Drawing.Point(150, 336);
            this.TransmissionComboBox.Name = "TransmissionComboBox";
            this.TransmissionComboBox.Size = new System.Drawing.Size(121, 28);
            this.TransmissionComboBox.TabIndex = 15;
            this.TransmissionComboBox.SelectedIndexChanged += new System.EventHandler(this.TransmissionComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(37, 393);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 45);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TransmissionComboBox);
            this.Controls.Add(this.ChangButton);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.YearOfMakeLabel);
            this.Controls.Add(this.DoorsLabel);
            this.Controls.Add(this.Transmission);
            this.Controls.Add(this.MakeTextBox);
            this.Controls.Add(this.ModeltextBox);
            this.Controls.Add(this.YearOfMaketextBox);
            this.Controls.Add(this.DoorstextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "EditForm";
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox DoorstextBox;
        private System.Windows.Forms.TextBox YearOfMaketextBox;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.Label Transmission;
        private System.Windows.Forms.Label DoorsLabel;
        private System.Windows.Forms.Label YearOfMakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Button ChangButton;
        private System.Windows.Forms.ComboBox TransmissionComboBox;
        private System.Windows.Forms.Button CancelButton;

        public TextBox NametextBox1 { get => NametextBox; set => NametextBox = value; }
        public TextBox DoorstextBox1 { get => DoorstextBox; set => DoorstextBox = value; }
        public TextBox YearOfMaketextBox1 { get => YearOfMaketextBox; set => YearOfMaketextBox = value; }
        public TextBox ModeltextBox1 { get => ModeltextBox; set => ModeltextBox = value; }
        public TextBox MakeTextBox1 { get => MakeTextBox; set => MakeTextBox = value; }
        public ComboBox TransmissionComboBox1 { get => TransmissionComboBox; set => TransmissionComboBox = value; }
    }
}