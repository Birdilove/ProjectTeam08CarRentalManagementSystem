namespace ProjectTeam08CarRentalManagementSystem
{
    partial class Add_Make
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
            this.buttonAddCarMake = new System.Windows.Forms.Button();
            this.labelAddMake = new System.Windows.Forms.Label();
            this.textBoxAddCarMake = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddCarMake
            // 
            this.buttonAddCarMake.Location = new System.Drawing.Point(72, 108);
            this.buttonAddCarMake.Name = "buttonAddCarMake";
            this.buttonAddCarMake.Size = new System.Drawing.Size(150, 40);
            this.buttonAddCarMake.TabIndex = 0;
            this.buttonAddCarMake.Text = "Add Make";
            this.buttonAddCarMake.UseVisualStyleBackColor = true;
            // 
            // labelAddMake
            // 
            this.labelAddMake.AutoSize = true;
            this.labelAddMake.ForeColor = System.Drawing.Color.White;
            this.labelAddMake.Location = new System.Drawing.Point(13, 60);
            this.labelAddMake.Name = "labelAddMake";
            this.labelAddMake.Size = new System.Drawing.Size(40, 13);
            this.labelAddMake.TabIndex = 1;
            this.labelAddMake.Text = "Make :";
            // 
            // textBoxAddCarMake
            // 
            this.textBoxAddCarMake.Location = new System.Drawing.Point(72, 57);
            this.textBoxAddCarMake.Name = "textBoxAddCarMake";
            this.textBoxAddCarMake.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddCarMake.TabIndex = 2;
            // 
            // Add_Make
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(243, 191);
            this.Controls.Add(this.textBoxAddCarMake);
            this.Controls.Add(this.labelAddMake);
            this.Controls.Add(this.buttonAddCarMake);
            this.Name = "Add_Make";
            this.Text = "Add_Make";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCarMake;
        private System.Windows.Forms.Label labelAddMake;
        private System.Windows.Forms.TextBox textBoxAddCarMake;
    }
}