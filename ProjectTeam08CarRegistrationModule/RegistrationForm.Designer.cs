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
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelAvailableCars = new System.Windows.Forms.Label();
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.labelEstimatedPrice = new System.Windows.Forms.Label();
            this.labelEstimatedPriceValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(57, 52);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(109, 17);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(240, 49);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNewCustomer.Location = new System.Drawing.Point(526, 48);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(225, 24);
            this.buttonNewCustomer.TabIndex = 2;
            this.buttonNewCustomer.Text = "Add New Customer";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(57, 102);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(84, 17);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Pickup Date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(240, 97);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(57, 157);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(73, 17);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "Drop Date";
            // 
            // labelAvailableCars
            // 
            this.labelAvailableCars.AutoSize = true;
            this.labelAvailableCars.Location = new System.Drawing.Point(57, 207);
            this.labelAvailableCars.Name = "labelAvailableCars";
            this.labelAvailableCars.Size = new System.Drawing.Size(98, 17);
            this.labelAvailableCars.TabIndex = 7;
            this.labelAvailableCars.Text = "Available Cars";
            // 
            // listBoxAvailableCars
            // 
            this.listBoxAvailableCars.FormattingEnabled = true;
            this.listBoxAvailableCars.ItemHeight = 16;
            this.listBoxAvailableCars.Location = new System.Drawing.Point(240, 197);
            this.listBoxAvailableCars.Name = "listBoxAvailableCars";
            this.listBoxAvailableCars.Size = new System.Drawing.Size(200, 148);
            this.listBoxAvailableCars.TabIndex = 8;
            // 
            // labelEstimatedPrice
            // 
            this.labelEstimatedPrice.AutoSize = true;
            this.labelEstimatedPrice.Location = new System.Drawing.Point(60, 385);
            this.labelEstimatedPrice.Name = "labelEstimatedPrice";
            this.labelEstimatedPrice.Size = new System.Drawing.Size(106, 17);
            this.labelEstimatedPrice.TabIndex = 9;
            this.labelEstimatedPrice.Text = "Estimated Price";
            // 
            // labelEstimatedPriceValue
            // 
            this.labelEstimatedPriceValue.AutoSize = true;
            this.labelEstimatedPriceValue.Location = new System.Drawing.Point(237, 385);
            this.labelEstimatedPriceValue.Name = "labelEstimatedPriceValue";
            this.labelEstimatedPriceValue.Size = new System.Drawing.Size(32, 17);
            this.labelEstimatedPriceValue.TabIndex = 10;
            this.labelEstimatedPriceValue.Text = "$12";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEstimatedPriceValue);
            this.Controls.Add(this.labelEstimatedPrice);
            this.Controls.Add(this.listBoxAvailableCars);
            this.Controls.Add(this.labelAvailableCars);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelAvailableCars;
        private System.Windows.Forms.ListBox listBoxAvailableCars;
        private System.Windows.Forms.Label labelEstimatedPrice;
        private System.Windows.Forms.Label labelEstimatedPriceValue;
    }
}

