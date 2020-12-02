namespace ProjectTeam08CarRegistrationModule
{
    partial class RegistrationForm
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
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelAvailableCars = new System.Windows.Forms.Label();
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.labelEstimatedPrice = new System.Windows.Forms.Label();
            this.labelEstimatedPriceValue = new System.Windows.Forms.Label();
            this.buttonRentCar = new System.Windows.Forms.Button();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(110, 51);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(108, 25);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer :";
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNewCustomer.Location = new System.Drawing.Point(617, 43);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(233, 40);
            this.buttonNewCustomer.TabIndex = 2;
            this.buttonNewCustomer.Text = "Add New Customer";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(90, 121);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(128, 25);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Pickup Date :";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(240, 116);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(295, 30);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(107, 190);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(111, 25);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "Drop Date :";
            // 
            // labelAvailableCars
            // 
            this.labelAvailableCars.AutoSize = true;
            this.labelAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableCars.Location = new System.Drawing.Point(68, 257);
            this.labelAvailableCars.Name = "labelAvailableCars";
            this.labelAvailableCars.Size = new System.Drawing.Size(150, 25);
            this.labelAvailableCars.TabIndex = 7;
            this.labelAvailableCars.Text = "Available Cars :";
            // 
            // listBoxAvailableCars
            // 
            this.listBoxAvailableCars.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAvailableCars.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxAvailableCars.FormattingEnabled = true;
            this.listBoxAvailableCars.ItemHeight = 25;
            this.listBoxAvailableCars.Location = new System.Drawing.Point(240, 257);
            this.listBoxAvailableCars.Name = "listBoxAvailableCars";
            this.listBoxAvailableCars.Size = new System.Drawing.Size(295, 254);
            this.listBoxAvailableCars.TabIndex = 8;
            // 
            // labelEstimatedPrice
            // 
            this.labelEstimatedPrice.AutoSize = true;
            this.labelEstimatedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedPrice.Location = new System.Drawing.Point(60, 549);
            this.labelEstimatedPrice.Name = "labelEstimatedPrice";
            this.labelEstimatedPrice.Size = new System.Drawing.Size(158, 25);
            this.labelEstimatedPrice.TabIndex = 9;
            this.labelEstimatedPrice.Text = "Estimated Price :";
            // 
            // labelEstimatedPriceValue
            // 
            this.labelEstimatedPriceValue.AutoSize = true;
            this.labelEstimatedPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedPriceValue.Location = new System.Drawing.Point(235, 549);
            this.labelEstimatedPriceValue.Name = "labelEstimatedPriceValue";
            this.labelEstimatedPriceValue.Size = new System.Drawing.Size(48, 25);
            this.labelEstimatedPriceValue.TabIndex = 10;
            this.labelEstimatedPriceValue.Text = "$12";
            // 
            // buttonRentCar
            // 
            this.buttonRentCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRentCar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRentCar.Location = new System.Drawing.Point(146, 651);
            this.buttonRentCar.Name = "buttonRentCar";
            this.buttonRentCar.Size = new System.Drawing.Size(235, 48);
            this.buttonRentCar.TabIndex = 11;
            this.buttonRentCar.Text = "Rent Car";
            this.buttonRentCar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(240, 48);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(295, 33);
            this.comboBoxCustomer.TabIndex = 1;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 749);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.buttonRentCar);
            this.Controls.Add(this.labelEstimatedPriceValue);
            this.Controls.Add(this.labelEstimatedPrice);
            this.Controls.Add(this.listBoxAvailableCars);
            this.Controls.Add(this.labelAvailableCars);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.labelCustomerName);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelAvailableCars;
        private System.Windows.Forms.ListBox listBoxAvailableCars;
        private System.Windows.Forms.Label labelEstimatedPrice;
        private System.Windows.Forms.Label labelEstimatedPriceValue;
        private System.Windows.Forms.Button buttonRentCar;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
    }
}

