namespace VojskaSrbije
{
    partial class DodajKategorijutereta
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
            this.label15 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeKategorije = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(133, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 62);
            this.label15.TabIndex = 74;
            this.label15.Text = "DODAVANJE NOVE\r\nKATEGORIJE TERETA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(332, 192);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(82, 29);
            this.buttonDodaj.TabIndex = 75;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Naziv kategorije:";
            // 
            // textBoxImeKategorije
            // 
            this.textBoxImeKategorije.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxImeKategorije.ForeColor = System.Drawing.Color.White;
            this.textBoxImeKategorije.Location = new System.Drawing.Point(187, 129);
            this.textBoxImeKategorije.Name = "textBoxImeKategorije";
            this.textBoxImeKategorije.Size = new System.Drawing.Size(231, 20);
            this.textBoxImeKategorije.TabIndex = 77;
            // 
            // DodajKategorijutereta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(497, 255);
            this.Controls.Add(this.textBoxImeKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label15);
            this.Name = "DodajKategorijutereta";
            this.Text = "DodajKategorijutereta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeKategorije;
    }
}