namespace VojskaSrbije
{
    partial class VidiObjekat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidiObjekat));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGradovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.comboBoxObjekti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVojnaPosta = new System.Windows.Forms.TextBox();
            this.textBoxImeObjekta = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFaks = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(151, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 134;
            this.label7.Text = "Vojna Posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(152, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 133;
            this.label6.Text = "Ime Objekta:";
            // 
            // comboBoxGradovi
            // 
            this.comboBoxGradovi.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxGradovi.ForeColor = System.Drawing.Color.White;
            this.comboBoxGradovi.FormattingEnabled = true;
            this.comboBoxGradovi.Location = new System.Drawing.Point(253, 573);
            this.comboBoxGradovi.Name = "comboBoxGradovi";
            this.comboBoxGradovi.Size = new System.Drawing.Size(209, 21);
            this.comboBoxGradovi.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(481, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 131;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 130;
            this.label3.Text = "Grad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column7,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(29, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 421);
            this.dataGridView1.TabIndex = 126;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Objekta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Ime Objekta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vojna Posta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ime Grada";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Telefon";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Faks";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(666, 642);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 125;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(355, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 31);
            this.label15.TabIndex = 123;
            this.label15.Text = "OBJEKTI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Selektovati Objekat za brisanje:";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.buttonObrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(666, 506);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 127;
            this.buttonObrisi.Text = "OBRIŠI";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // comboBoxObjekti
            // 
            this.comboBoxObjekti.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxObjekti.ForeColor = System.Drawing.Color.White;
            this.comboBoxObjekti.FormattingEnabled = true;
            this.comboBoxObjekti.Location = new System.Drawing.Point(257, 479);
            this.comboBoxObjekti.Name = "comboBoxObjekti";
            this.comboBoxObjekti.Size = new System.Drawing.Size(484, 21);
            this.comboBoxObjekti.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "Upisati Objekat za dodavanje:";
            // 
            // textBoxVojnaPosta
            // 
            this.textBoxVojnaPosta.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxVojnaPosta.ForeColor = System.Drawing.Color.White;
            this.textBoxVojnaPosta.Location = new System.Drawing.Point(253, 604);
            this.textBoxVojnaPosta.Name = "textBoxVojnaPosta";
            this.textBoxVojnaPosta.Size = new System.Drawing.Size(209, 20);
            this.textBoxVojnaPosta.TabIndex = 136;
            // 
            // textBoxImeObjekta
            // 
            this.textBoxImeObjekta.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxImeObjekta.ForeColor = System.Drawing.Color.White;
            this.textBoxImeObjekta.Location = new System.Drawing.Point(253, 543);
            this.textBoxImeObjekta.Name = "textBoxImeObjekta";
            this.textBoxImeObjekta.Size = new System.Drawing.Size(209, 20);
            this.textBoxImeObjekta.TabIndex = 137;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxTelefon.ForeColor = System.Drawing.Color.White;
            this.textBoxTelefon.Location = new System.Drawing.Point(546, 576);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(195, 20);
            this.textBoxTelefon.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(496, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 139;
            this.label5.Text = "Faks:";
            // 
            // textBoxFaks
            // 
            this.textBoxFaks.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxFaks.ForeColor = System.Drawing.Color.White;
            this.textBoxFaks.Location = new System.Drawing.Point(546, 604);
            this.textBoxFaks.Name = "textBoxFaks";
            this.textBoxFaks.Size = new System.Drawing.Size(197, 20);
            this.textBoxFaks.TabIndex = 140;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(666, 533);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 141;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // VidiObjekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(865, 699);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxFaks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxImeObjekta);
            this.Controls.Add(this.textBoxVojnaPosta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGradovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.comboBoxObjekti);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VidiObjekat";
            this.Text = "VidiObjekat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGradovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.ComboBox comboBoxObjekti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxVojnaPosta;
        private System.Windows.Forms.TextBox textBoxImeObjekta;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFaks;
        private System.Windows.Forms.Button buttonEdit;
    }
}