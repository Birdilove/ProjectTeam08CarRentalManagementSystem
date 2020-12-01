namespace ProjectTeam08CarRentalManagementSystem
{
    partial class ViewReport
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
            this.labelViewReportTitle = new System.Windows.Forms.Label();
            this.dataGridViewReturnedCar = new System.Windows.Forms.DataGridView();
            this.labelDateFilterTitle = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.buttonDateFilter = new System.Windows.Forms.Button();
            this.labelReservationTitle = new System.Windows.Forms.Label();
            this.labelTotalTitle = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.labelNoReturn = new System.Windows.Forms.Label();
            this.dataGridViewNotYetReturned = new System.Windows.Forms.DataGridView();
            this.labelEstimatedTotal = new System.Windows.Forms.Label();
            this.labelEstimatedTotalTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotYetReturned)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewReportTitle
            // 
            this.labelViewReportTitle.AutoSize = true;
            this.labelViewReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelViewReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelViewReportTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelViewReportTitle.Location = new System.Drawing.Point(308, 45);
            this.labelViewReportTitle.Name = "labelViewReportTitle";
            this.labelViewReportTitle.Size = new System.Drawing.Size(176, 38);
            this.labelViewReportTitle.TabIndex = 0;
            this.labelViewReportTitle.Text = "Log Report";
            // 
            // dataGridViewReturnedCar
            // 
            this.dataGridViewReturnedCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnedCar.Location = new System.Drawing.Point(40, 264);
            this.dataGridViewReturnedCar.Name = "dataGridViewReturnedCar";
            this.dataGridViewReturnedCar.RowHeadersWidth = 51;
            this.dataGridViewReturnedCar.RowTemplate.Height = 24;
            this.dataGridViewReturnedCar.Size = new System.Drawing.Size(671, 207);
            this.dataGridViewReturnedCar.TabIndex = 1;
            // 
            // labelDateFilterTitle
            // 
            this.labelDateFilterTitle.AutoSize = true;
            this.labelDateFilterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDateFilterTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDateFilterTitle.Location = new System.Drawing.Point(618, 108);
            this.labelDateFilterTitle.Name = "labelDateFilterTitle";
            this.labelDateFilterTitle.Size = new System.Drawing.Size(88, 20);
            this.labelDateFilterTitle.TabIndex = 2;
            this.labelDateFilterTitle.Text = "Date Filter";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStartDate.Location = new System.Drawing.Point(505, 145);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(70, 17);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(581, 145);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelEndDate.Location = new System.Drawing.Point(508, 186);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(67, 17);
            this.labelEndDate.TabIndex = 5;
            this.labelEndDate.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(581, 186);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerEndDate.TabIndex = 6;
            // 
            // buttonDateFilter
            // 
            this.buttonDateFilter.Location = new System.Drawing.Point(631, 224);
            this.buttonDateFilter.Name = "buttonDateFilter";
            this.buttonDateFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonDateFilter.TabIndex = 7;
            this.buttonDateFilter.Text = "View";
            this.buttonDateFilter.UseVisualStyleBackColor = true;
            // 
            // labelReservationTitle
            // 
            this.labelReservationTitle.AutoSize = true;
            this.labelReservationTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelReservationTitle.Location = new System.Drawing.Point(37, 244);
            this.labelReservationTitle.Name = "labelReservationTitle";
            this.labelReservationTitle.Size = new System.Drawing.Size(116, 21);
            this.labelReservationTitle.TabIndex = 8;
            this.labelReservationTitle.Text = "Returned Car";
            // 
            // labelTotalTitle
            // 
            this.labelTotalTitle.AutoSize = true;
            this.labelTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotalTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotalTitle.Location = new System.Drawing.Point(537, 474);
            this.labelTotalTitle.Name = "labelTotalTitle";
            this.labelTotalTitle.Size = new System.Drawing.Size(69, 20);
            this.labelTotalTitle.TabIndex = 13;
            this.labelTotalTitle.Text = "Total : ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(603, 474);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 20);
            this.labelTotal.TabIndex = 14;
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Location = new System.Drawing.Point(541, 224);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilter.TabIndex = 15;
            this.buttonResetFilter.Text = "Reset";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            // 
            // labelNoReturn
            // 
            this.labelNoReturn.AutoSize = true;
            this.labelNoReturn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNoReturn.Location = new System.Drawing.Point(37, 495);
            this.labelNoReturn.Name = "labelNoReturn";
            this.labelNoReturn.Size = new System.Drawing.Size(145, 21);
            this.labelNoReturn.TabIndex = 17;
            this.labelNoReturn.Text = "Not yet Returned";
            // 
            // dataGridViewNotYetReturned
            // 
            this.dataGridViewNotYetReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotYetReturned.Location = new System.Drawing.Point(40, 515);
            this.dataGridViewNotYetReturned.Name = "dataGridViewNotYetReturned";
            this.dataGridViewNotYetReturned.RowHeadersWidth = 51;
            this.dataGridViewNotYetReturned.RowTemplate.Height = 24;
            this.dataGridViewNotYetReturned.Size = new System.Drawing.Size(671, 207);
            this.dataGridViewNotYetReturned.TabIndex = 16;
            // 
            // labelEstimatedTotal
            // 
            this.labelEstimatedTotal.AutoSize = true;
            this.labelEstimatedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEstimatedTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstimatedTotal.Location = new System.Drawing.Point(603, 725);
            this.labelEstimatedTotal.Name = "labelEstimatedTotal";
            this.labelEstimatedTotal.Size = new System.Drawing.Size(0, 20);
            this.labelEstimatedTotal.TabIndex = 19;
            // 
            // labelEstimatedTotalTitle
            // 
            this.labelEstimatedTotalTitle.AutoSize = true;
            this.labelEstimatedTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEstimatedTotalTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstimatedTotalTitle.Location = new System.Drawing.Point(444, 725);
            this.labelEstimatedTotalTitle.Name = "labelEstimatedTotalTitle";
            this.labelEstimatedTotalTitle.Size = new System.Drawing.Size(159, 20);
            this.labelEstimatedTotalTitle.TabIndex = 18;
            this.labelEstimatedTotalTitle.Text = "Estimated Total : ";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(749, 768);
            this.Controls.Add(this.labelEstimatedTotal);
            this.Controls.Add(this.labelEstimatedTotalTitle);
            this.Controls.Add(this.labelNoReturn);
            this.Controls.Add(this.dataGridViewNotYetReturned);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTotalTitle);
            this.Controls.Add(this.labelReservationTitle);
            this.Controls.Add(this.buttonDateFilter);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDateFilterTitle);
            this.Controls.Add(this.dataGridViewReturnedCar);
            this.Controls.Add(this.labelViewReportTitle);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotYetReturned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewReportTitle;
        private System.Windows.Forms.DataGridView dataGridViewReturnedCar;
        private System.Windows.Forms.Label labelDateFilterTitle;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonDateFilter;
        private System.Windows.Forms.Label labelReservationTitle;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Label labelNoReturn;
        private System.Windows.Forms.DataGridView dataGridViewNotYetReturned;
        private System.Windows.Forms.Label labelEstimatedTotal;
        private System.Windows.Forms.Label labelEstimatedTotalTitle;
    }
}