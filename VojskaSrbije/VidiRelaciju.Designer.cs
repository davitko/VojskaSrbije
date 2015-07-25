namespace VojskaSrbije
{
    partial class VidiRelaciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidiRelaciju));
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxObjektiUtovara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.comboBoxRelacije = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxObjektiIstovara = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVremeUtovara = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVremeIstovara = new System.Windows.Forms.DateTimePicker();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(395, 666);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 118;
            this.label6.Text = "Vreme Istovara:";
            // 
            // comboBoxObjektiUtovara
            // 
            this.comboBoxObjektiUtovara.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxObjektiUtovara.ForeColor = System.Drawing.Color.White;
            this.comboBoxObjektiUtovara.FormattingEnabled = true;
            this.comboBoxObjektiUtovara.Location = new System.Drawing.Point(216, 631);
            this.comboBoxObjektiUtovara.Name = "comboBoxObjektiUtovara";
            this.comboBoxObjektiUtovara.Size = new System.Drawing.Size(158, 21);
            this.comboBoxObjektiUtovara.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 113;
            this.label4.Text = "Vreme Utovara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 112;
            this.label3.Text = "Objekat Utovara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(24, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 456);
            this.dataGridView1.TabIndex = 107;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(595, 704);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 106;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(325, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 31);
            this.label15.TabIndex = 104;
            this.label15.Text = "RELACIJE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Selektovati Relaciju za brisanje:";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.buttonObrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(668, 547);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 108;
            this.buttonObrisi.Text = "OBRIŠI";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // comboBoxRelacije
            // 
            this.comboBoxRelacije.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxRelacije.ForeColor = System.Drawing.Color.White;
            this.comboBoxRelacije.FormattingEnabled = true;
            this.comboBoxRelacije.Location = new System.Drawing.Point(209, 520);
            this.comboBoxRelacije.Name = "comboBoxRelacije";
            this.comboBoxRelacije.Size = new System.Drawing.Size(534, 21);
            this.comboBoxRelacije.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Upisati Relaciju za dodavanje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(387, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 119;
            this.label7.Text = "Objekat Istovara:";
            // 
            // comboBoxObjektiIstovara
            // 
            this.comboBoxObjektiIstovara.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxObjektiIstovara.ForeColor = System.Drawing.Color.White;
            this.comboBoxObjektiIstovara.FormattingEnabled = true;
            this.comboBoxObjektiIstovara.Location = new System.Drawing.Point(511, 627);
            this.comboBoxObjektiIstovara.Name = "comboBoxObjektiIstovara";
            this.comboBoxObjektiIstovara.Size = new System.Drawing.Size(158, 21);
            this.comboBoxObjektiIstovara.TabIndex = 120;
            // 
            // dateTimePickerVremeUtovara
            // 
            this.dateTimePickerVremeUtovara.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerVremeUtovara.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePickerVremeUtovara.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVremeUtovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeUtovara.Location = new System.Drawing.Point(216, 665);
            this.dateTimePickerVremeUtovara.Name = "dateTimePickerVremeUtovara";
            this.dateTimePickerVremeUtovara.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerVremeUtovara.TabIndex = 121;
            // 
            // dateTimePickerVremeIstovara
            // 
            this.dateTimePickerVremeIstovara.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerVremeIstovara.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePickerVremeIstovara.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVremeIstovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeIstovara.Location = new System.Drawing.Point(512, 666);
            this.dateTimePickerVremeIstovara.Name = "dateTimePickerVremeIstovara";
            this.dateTimePickerVremeIstovara.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerVremeIstovara.TabIndex = 122;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(668, 576);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 123;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Relacije";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Objekat Utovara";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mesto Utovara";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Objekat Istovara";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mesto Istovara";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vreme Utovara";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Vreme Istovara";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // VidiRelaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(834, 752);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dateTimePickerVremeIstovara);
            this.Controls.Add(this.dateTimePickerVremeUtovara);
            this.Controls.Add(this.comboBoxObjektiIstovara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxObjektiUtovara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.comboBoxRelacije);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VidiRelaciju";
            this.Text = "VidiRelaciju";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxObjektiUtovara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.ComboBox comboBoxRelacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxObjektiIstovara;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeUtovara;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeIstovara;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}