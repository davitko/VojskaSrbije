namespace VojskaSrbije
{
    partial class DodajRelaciju
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
            this.dateTimePickerVremeIstovara = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVremeUtovara = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxPrimilac = new System.Windows.Forms.ComboBox();
            this.comboBoxPosiljalac = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(162, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 62);
            this.label15.TabIndex = 76;
            this.label15.Text = "DODAVANJE NOVE\r\nRELACIJE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerVremeIstovara
            // 
            this.dateTimePickerVremeIstovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeIstovara.Location = new System.Drawing.Point(233, 222);
            this.dateTimePickerVremeIstovara.Name = "dateTimePickerVremeIstovara";
            this.dateTimePickerVremeIstovara.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVremeIstovara.TabIndex = 82;
            // 
            // dateTimePickerVremeUtovara
            // 
            this.dateTimePickerVremeUtovara.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerVremeUtovara.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePickerVremeUtovara.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVremeUtovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeUtovara.Location = new System.Drawing.Point(234, 195);
            this.dateTimePickerVremeUtovara.Name = "dateTimePickerVremeUtovara";
            this.dateTimePickerVremeUtovara.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerVremeUtovara.TabIndex = 81;
            this.dateTimePickerVremeUtovara.ValueChanged += new System.EventHandler(this.dateTimePickerVremeUtovara_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(80, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 23);
            this.label14.TabIndex = 80;
            this.label14.Text = "Vreme istovara:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(77, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 23);
            this.label13.TabIndex = 79;
            this.label13.Text = "Vreme utovara:";
            // 
            // comboBoxPrimilac
            // 
            this.comboBoxPrimilac.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxPrimilac.ForeColor = System.Drawing.Color.White;
            this.comboBoxPrimilac.FormattingEnabled = true;
            this.comboBoxPrimilac.Location = new System.Drawing.Point(233, 148);
            this.comboBoxPrimilac.Name = "comboBoxPrimilac";
            this.comboBoxPrimilac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPrimilac.TabIndex = 89;
            // 
            // comboBoxPosiljalac
            // 
            this.comboBoxPosiljalac.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxPosiljalac.ForeColor = System.Drawing.Color.White;
            this.comboBoxPosiljalac.FormattingEnabled = true;
            this.comboBoxPosiljalac.Location = new System.Drawing.Point(233, 119);
            this.comboBoxPosiljalac.Name = "comboBoxPosiljalac";
            this.comboBoxPosiljalac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPosiljalac.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(134, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 87;
            this.label11.Text = "Primalac:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(126, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 86;
            this.label10.Text = "Pošiljalac:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(358, 309);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 29);
            this.buttonDodaj.TabIndex = 90;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // DodajRelaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(521, 395);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxPrimilac);
            this.Controls.Add(this.comboBoxPosiljalac);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerVremeIstovara);
            this.Controls.Add(this.dateTimePickerVremeUtovara);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Name = "DodajRelaciju";
            this.Text = "DodajRelaciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeIstovara;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeUtovara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxPrimilac;
        private System.Windows.Forms.ComboBox comboBoxPosiljalac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDodaj;
    }
}