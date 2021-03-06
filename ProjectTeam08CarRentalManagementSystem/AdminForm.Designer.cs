﻿namespace ProjectTeam08CarRentalManagementSystem
{
    partial class AdminForm
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
            this.dataGridViewAvailableCars = new System.Windows.Forms.DataGridView();
            this.buttonBackupDatabase = new System.Windows.Forms.Button();
            this.buttonViewReports = new System.Windows.Forms.Button();
            this.buttonAddNewCar = new System.Windows.Forms.Button();
            this.labelAvailableCars = new System.Windows.Forms.Label();
            this.dataGridViewRentedCars = new System.Windows.Forms.DataGridView();
            this.labelRentedCars = new System.Windows.Forms.Label();
            this.buttonMoveToAvailable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableCars
            // 
            this.dataGridViewAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCars.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewAvailableCars.Name = "dataGridViewAvailableCars";
            this.dataGridViewAvailableCars.Size = new System.Drawing.Size(462, 222);
            this.dataGridViewAvailableCars.TabIndex = 3;
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.Location = new System.Drawing.Point(506, 326);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(150, 40);
            this.buttonBackupDatabase.TabIndex = 7;
            this.buttonBackupDatabase.Text = "Backup Database";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonViewReports
            // 
            this.buttonViewReports.Location = new System.Drawing.Point(506, 280);
            this.buttonViewReports.Name = "buttonViewReports";
            this.buttonViewReports.Size = new System.Drawing.Size(150, 40);
            this.buttonViewReports.TabIndex = 6;
            this.buttonViewReports.Text = "View Reports";
            this.buttonViewReports.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewCar
            // 
            this.buttonAddNewCar.Location = new System.Drawing.Point(306, 280);
            this.buttonAddNewCar.Name = "buttonAddNewCar";
            this.buttonAddNewCar.Size = new System.Drawing.Size(150, 40);
            this.buttonAddNewCar.TabIndex = 5;
            this.buttonAddNewCar.Text = "Add New Car";
            this.buttonAddNewCar.UseVisualStyleBackColor = true;
            // 
            // labelAvailableCars
            // 
            this.labelAvailableCars.AutoSize = true;
            this.labelAvailableCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableCars.ForeColor = System.Drawing.Color.White;
            this.labelAvailableCars.Location = new System.Drawing.Point(12, 9);
            this.labelAvailableCars.Name = "labelAvailableCars";
            this.labelAvailableCars.Size = new System.Drawing.Size(125, 22);
            this.labelAvailableCars.TabIndex = 8;
            this.labelAvailableCars.Text = "Available Cars";
            // 
            // dataGridViewRentedCars
            // 
            this.dataGridViewRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentedCars.Location = new System.Drawing.Point(491, 34);
            this.dataGridViewRentedCars.Name = "dataGridViewRentedCars";
            this.dataGridViewRentedCars.Size = new System.Drawing.Size(461, 222);
            this.dataGridViewRentedCars.TabIndex = 9;
            // 
            // labelRentedCars
            // 
            this.labelRentedCars.AutoSize = true;
            this.labelRentedCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRentedCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentedCars.ForeColor = System.Drawing.Color.White;
            this.labelRentedCars.Location = new System.Drawing.Point(491, 9);
            this.labelRentedCars.Name = "labelRentedCars";
            this.labelRentedCars.Size = new System.Drawing.Size(112, 22);
            this.labelRentedCars.TabIndex = 10;
            this.labelRentedCars.Text = "Rented Cars";
            // 
            // buttonMoveToAvailable
            // 
            this.buttonMoveToAvailable.Location = new System.Drawing.Point(306, 326);
            this.buttonMoveToAvailable.Name = "buttonMoveToAvailable";
            this.buttonMoveToAvailable.Size = new System.Drawing.Size(150, 40);
            this.buttonMoveToAvailable.TabIndex = 12;
            this.buttonMoveToAvailable.Text = "Move to Available";
            this.buttonMoveToAvailable.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(964, 391);
            this.Controls.Add(this.buttonMoveToAvailable);
            this.Controls.Add(this.labelRentedCars);
            this.Controls.Add(this.dataGridViewRentedCars);
            this.Controls.Add(this.labelAvailableCars);
            this.Controls.Add(this.buttonBackupDatabase);
            this.Controls.Add(this.buttonViewReports);
            this.Controls.Add(this.buttonAddNewCar);
            this.Controls.Add(this.dataGridViewAvailableCars);
            this.Name = "AdminForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvailableCars;
        private System.Windows.Forms.Button buttonBackupDatabase;
        private System.Windows.Forms.Button buttonViewReports;
        private System.Windows.Forms.Button buttonAddNewCar;
        private System.Windows.Forms.Label labelAvailableCars;
        private System.Windows.Forms.DataGridView dataGridViewRentedCars;
        private System.Windows.Forms.Label labelRentedCars;
        private System.Windows.Forms.Button buttonMoveToAvailable;
    }
}

