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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAddType = new System.Windows.Forms.Label();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.ForeColor = System.Drawing.Color.White;
            this.labelAddType.Location = new System.Drawing.Point(13, 68);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(37, 13);
            this.labelAddType.TabIndex = 1;
            this.labelAddType.Text = "Type :";
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(68, 119);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(150, 40);
            this.buttonAddType.TabIndex = 2;
            this.buttonAddType.Text = "Add Type";
            this.buttonAddType.UseVisualStyleBackColor = true;
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(249, 220);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.labelAddType);
            this.Controls.Add(this.textBox1);
            this.Name = "AddType";
            this.Text = "AddType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAddType;
        private System.Windows.Forms.Button buttonAddType;
    }
}