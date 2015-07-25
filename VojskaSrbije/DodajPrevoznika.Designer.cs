namespace VojskaSrbije
{
    partial class DodajPrevoznika
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
            this.textBoxPrevoznoSredstvo = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObjekti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegBr = new System.Windows.Forms.TextBox();
            this.textBoxVojnaPosta = new System.Windows.Forms.TextBox();
            this.textBoxVozac = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonObjekatPrevoznika = new System.Windows.Forms.RadioButton();
            this.radioButtonVojnaPostaPrevoznika = new System.Windows.Forms.RadioButton();
            this.buttonDodajObjekat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(104, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 62);
            this.label15.TabIndex = 74;
            this.label15.Text = "DODAVANJE NOVOG\r\nPREVOZNIKA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPrevoznoSredstvo
            // 
            this.textBoxPrevoznoSredstvo.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxPrevoznoSredstvo.ForeColor = System.Drawing.Color.White;
            this.textBoxPrevoznoSredstvo.Location = new System.Drawing.Point(285, 98);
            this.textBoxPrevoznoSredstvo.Name = "textBoxPrevoznoSredstvo";
            this.textBoxPrevoznoSredstvo.Size = new System.Drawing.Size(257, 20);
            this.textBoxPrevoznoSredstvo.TabIndex = 79;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(467, 425);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 29);
            this.buttonDodaj.TabIndex = 78;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 77;
            this.label2.Text = "Vozač:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Naziv Prevoznog Sredstva:";
            // 
            // comboBoxObjekti
            // 
            this.comboBoxObjekti.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxObjekti.Enabled = false;
            this.comboBoxObjekti.ForeColor = System.Drawing.Color.White;
            this.comboBoxObjekti.FormattingEnabled = true;
            this.comboBoxObjekti.Location = new System.Drawing.Point(273, 84);
            this.comboBoxObjekti.Name = "comboBoxObjekti";
            this.comboBoxObjekti.Size = new System.Drawing.Size(240, 31);
            this.comboBoxObjekti.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "Registracioni Broj:";
            // 
            // textBoxRegBr
            // 
            this.textBoxRegBr.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxRegBr.ForeColor = System.Drawing.Color.White;
            this.textBoxRegBr.Location = new System.Drawing.Point(285, 138);
            this.textBoxRegBr.Name = "textBoxRegBr";
            this.textBoxRegBr.Size = new System.Drawing.Size(156, 20);
            this.textBoxRegBr.TabIndex = 81;
            // 
            // textBoxVojnaPosta
            // 
            this.textBoxVojnaPosta.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxVojnaPosta.ForeColor = System.Drawing.Color.White;
            this.textBoxVojnaPosta.Location = new System.Drawing.Point(273, 26);
            this.textBoxVojnaPosta.Name = "textBoxVojnaPosta";
            this.textBoxVojnaPosta.Size = new System.Drawing.Size(156, 30);
            this.textBoxVojnaPosta.TabIndex = 84;
            // 
            // textBoxVozac
            // 
            this.textBoxVozac.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxVozac.ForeColor = System.Drawing.Color.White;
            this.textBoxVozac.Location = new System.Drawing.Point(285, 356);
            this.textBoxVozac.Name = "textBoxVozac";
            this.textBoxVozac.Size = new System.Drawing.Size(156, 20);
            this.textBoxVozac.TabIndex = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.buttonDodajObjekat);
            this.groupBox1.Controls.Add(this.radioButtonObjekatPrevoznika);
            this.groupBox1.Controls.Add(this.radioButtonVojnaPostaPrevoznika);
            this.groupBox1.Controls.Add(this.textBoxVojnaPosta);
            this.groupBox1.Controls.Add(this.comboBoxObjekti);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 168);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objekat Prevoznika";
            // 
            // radioButtonObjekatPrevoznika
            // 
            this.radioButtonObjekatPrevoznika.AutoSize = true;
            this.radioButtonObjekatPrevoznika.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonObjekatPrevoznika.ForeColor = System.Drawing.Color.White;
            this.radioButtonObjekatPrevoznika.Location = new System.Drawing.Point(40, 78);
            this.radioButtonObjekatPrevoznika.Name = "radioButtonObjekatPrevoznika";
            this.radioButtonObjekatPrevoznika.Size = new System.Drawing.Size(205, 27);
            this.radioButtonObjekatPrevoznika.TabIndex = 1;
            this.radioButtonObjekatPrevoznika.Text = "Objekat Prevoznika:";
            this.radioButtonObjekatPrevoznika.UseVisualStyleBackColor = true;
            this.radioButtonObjekatPrevoznika.CheckedChanged += new System.EventHandler(this.radioButtonObjekatPrevoznika_CheckedChanged);
            // 
            // radioButtonVojnaPostaPrevoznika
            // 
            this.radioButtonVojnaPostaPrevoznika.AutoSize = true;
            this.radioButtonVojnaPostaPrevoznika.Checked = true;
            this.radioButtonVojnaPostaPrevoznika.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonVojnaPostaPrevoznika.ForeColor = System.Drawing.Color.White;
            this.radioButtonVojnaPostaPrevoznika.Location = new System.Drawing.Point(6, 33);
            this.radioButtonVojnaPostaPrevoznika.Name = "radioButtonVojnaPostaPrevoznika";
            this.radioButtonVojnaPostaPrevoznika.Size = new System.Drawing.Size(241, 27);
            this.radioButtonVojnaPostaPrevoznika.TabIndex = 0;
            this.radioButtonVojnaPostaPrevoznika.TabStop = true;
            this.radioButtonVojnaPostaPrevoznika.Text = "Vojna Posta Prevoznika:";
            this.radioButtonVojnaPostaPrevoznika.UseVisualStyleBackColor = true;
            this.radioButtonVojnaPostaPrevoznika.CheckedChanged += new System.EventHandler(this.radioButtonVojnaPostaPrevoznika_CheckedChanged);
            // 
            // buttonDodajObjekat
            // 
            this.buttonDodajObjekat.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodajObjekat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodajObjekat.Location = new System.Drawing.Point(315, 125);
            this.buttonDodajObjekat.Name = "buttonDodajObjekat";
            this.buttonDodajObjekat.Size = new System.Drawing.Size(114, 31);
            this.buttonDodajObjekat.TabIndex = 85;
            this.buttonDodajObjekat.Text = "Dodaj Objekat";
            this.buttonDodajObjekat.UseVisualStyleBackColor = false;
            this.buttonDodajObjekat.Click += new System.EventHandler(this.buttonDodajObjekat_Click);
            // 
            // DodajPrevoznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(571, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxVozac);
            this.Controls.Add(this.textBoxRegBr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrevoznoSredstvo);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "DodajPrevoznika";
            this.Text = "Prevoznik";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPrevoznoSredstvo;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxObjekti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegBr;
        private System.Windows.Forms.TextBox textBoxVojnaPosta;
        private System.Windows.Forms.TextBox textBoxVozac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonObjekatPrevoznika;
        private System.Windows.Forms.RadioButton radioButtonVojnaPostaPrevoznika;
        private System.Windows.Forms.Button buttonDodajObjekat;
    }
}