namespace ProjectTeam08CarRentalManagementSystem
{
    partial class AddType
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
            this.textBoxCarType = new System.Windows.Forms.TextBox();
            this.labelAddType = new System.Windows.Forms.Label();
            this.buttonAddCarType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCarType
            // 
            this.textBoxCarType.Location = new System.Drawing.Point(68, 52);
            this.textBoxCarType.Name = "textBoxCarType";
            this.textBoxCarType.Size = new System.Drawing.Size(150, 20);
            this.textBoxCarType.TabIndex = 0;
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.ForeColor = System.Drawing.Color.White;
            this.labelAddType.Location = new System.Drawing.Point(13, 55);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(37, 13);
            this.labelAddType.TabIndex = 1;
            this.labelAddType.Text = "Type :";
            // 
            // buttonAddCarType
            // 
            this.buttonAddCarType.Location = new System.Drawing.Point(68, 106);
            this.buttonAddCarType.Name = "buttonAddCarType";
            this.buttonAddCarType.Size = new System.Drawing.Size(150, 40);
            this.buttonAddCarType.TabIndex = 2;
            this.buttonAddCarType.Text = "Add Type";
            this.buttonAddCarType.UseVisualStyleBackColor = true;
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(243, 191);
            this.Controls.Add(this.buttonAddCarType);
            this.Controls.Add(this.labelAddType);
            this.Controls.Add(this.textBoxCarType);
            this.Name = "AddType";
            this.Text = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarType;
        private System.Windows.Forms.Label labelAddType;
        private System.Windows.Forms.Button buttonAddCarType;
    }
}