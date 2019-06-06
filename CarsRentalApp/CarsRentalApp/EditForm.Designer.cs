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
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(123, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(77, 29);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NametextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(289, 63);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(249, 35);
            this.NametextBox.TabIndex = 1;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // DoorstextBox
            // 
            this.DoorstextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorstextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorstextBox.Location = new System.Drawing.Point(289, 278);
            this.DoorstextBox.Name = "DoorstextBox";
            this.DoorstextBox.Size = new System.Drawing.Size(249, 35);
            this.DoorstextBox.TabIndex = 3;
            this.DoorstextBox.TextChanged += new System.EventHandler(this.DoorstextBox_TextChanged);
            // 
            // YearOfMaketextBox
            // 
            this.YearOfMaketextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearOfMaketextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearOfMaketextBox.Location = new System.Drawing.Point(289, 221);
            this.YearOfMaketextBox.Name = "YearOfMaketextBox";
            this.YearOfMaketextBox.Size = new System.Drawing.Size(249, 35);
            this.YearOfMaketextBox.TabIndex = 4;
            this.YearOfMaketextBox.TextChanged += new System.EventHandler(this.YearOfMaketextBox_TextChanged);
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeltextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeltextBox.Location = new System.Drawing.Point(289, 170);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(249, 35);
            this.ModeltextBox.TabIndex = 5;
            this.ModeltextBox.TextChanged += new System.EventHandler(this.ModeltextBox_TextChanged);
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeTextBox.Location = new System.Drawing.Point(289, 115);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(249, 35);
            this.MakeTextBox.TabIndex = 6;
            this.MakeTextBox.TextChanged += new System.EventHandler(this.MakeTextBox_TextChanged);
            // 
            // Transmission
            // 
            this.Transmission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transmission.AutoSize = true;
            this.Transmission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transmission.Location = new System.Drawing.Point(93, 334);
            this.Transmission.Name = "Transmission";
            this.Transmission.Size = new System.Drawing.Size(168, 29);
            this.Transmission.TabIndex = 9;
            this.Transmission.Text = "Transmission";
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorsLabel.Location = new System.Drawing.Point(123, 284);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(82, 29);
            this.DoorsLabel.TabIndex = 10;
            this.DoorsLabel.Text = "Doors";
            // 
            // YearOfMakeLabel
            // 
            this.YearOfMakeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearOfMakeLabel.AutoSize = true;
            this.YearOfMakeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearOfMakeLabel.Location = new System.Drawing.Point(88, 233);
            this.YearOfMakeLabel.Name = "YearOfMakeLabel";
            this.YearOfMakeLabel.Size = new System.Drawing.Size(162, 29);
            this.YearOfMakeLabel.TabIndex = 11;
            this.YearOfMakeLabel.Text = "Year Of Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(123, 176);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(84, 29);
            this.ModelLabel.TabIndex = 12;
            this.ModelLabel.Text = "Model";
            // 
            // MakeLabel
            // 
            this.MakeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(123, 121);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(73, 29);
            this.MakeLabel.TabIndex = 13;
            this.MakeLabel.Text = "Make";
            // 
            // ChangButton
            // 
            this.ChangButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangButton.AutoSize = true;
            this.ChangButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangButton.Location = new System.Drawing.Point(385, 404);
            this.ChangButton.Name = "ChangButton";
            this.ChangButton.Size = new System.Drawing.Size(134, 51);
            this.ChangButton.TabIndex = 14;
            this.ChangButton.Text = "Change";
            this.ChangButton.UseVisualStyleBackColor = true;
            this.ChangButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TransmissionComboBox
            // 
            this.TransmissionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransmissionComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionComboBox.FormattingEnabled = true;
            this.TransmissionComboBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransmissionComboBox.Location = new System.Drawing.Point(289, 328);
            this.TransmissionComboBox.Name = "TransmissionComboBox";
            this.TransmissionComboBox.Size = new System.Drawing.Size(249, 37);
            this.TransmissionComboBox.TabIndex = 15;
            this.TransmissionComboBox.SelectedIndexChanged += new System.EventHandler(this.TransmissionComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(167, 404);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(134, 51);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(646, 490);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.Text = "Edit Car";
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