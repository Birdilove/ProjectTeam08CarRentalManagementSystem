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
            this.buttonAddMake = new System.Windows.Forms.Button();
            this.labelAddMake = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddMake
            // 
            this.buttonAddMake.Location = new System.Drawing.Point(72, 108);
            this.buttonAddMake.Name = "buttonAddMake";
            this.buttonAddMake.Size = new System.Drawing.Size(150, 40);
            this.buttonAddMake.TabIndex = 0;
            this.buttonAddMake.Text = "Add Make";
            this.buttonAddMake.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Add_Make
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(243, 191);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAddMake);
            this.Controls.Add(this.buttonAddMake);
            this.Name = "Add_Make";
            this.Text = "Add_Make";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMake;
        private System.Windows.Forms.Label labelAddMake;
        private System.Windows.Forms.TextBox textBox1;
    }
}