namespace VojskaSrbije
{
    partial class VidiTeret
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.comboBoxTeret = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoviTeretUN = new System.Windows.Forms.TextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNoviTeretProizvodjac = new System.Windows.Forms.TextBox();
            this.textBoxNoviTeretNazivtereta = new System.Windows.Forms.TextBox();
            this.comboBoxKategorijeTereta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 505);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Tereta";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "UN broj Tereta ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kategorija Tereta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Naziv Tereta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Proizvodjac";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDodaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(420, 800);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 91;
            this.buttonDodaj.Text = "DODAJ";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // comboBoxTeret
            // 
            this.comboBoxTeret.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxTeret.ForeColor = System.Drawing.Color.White;
            this.comboBoxTeret.FormattingEnabled = true;
            this.comboBoxTeret.Location = new System.Drawing.Point(231, 594);
            this.comboBoxTeret.Name = "comboBoxTeret";
            this.comboBoxTeret.Size = new System.Drawing.Size(264, 21);
            this.comboBoxTeret.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(226, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 31);
            this.label15.TabIndex = 89;
            this.label15.Text = "TERET";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Upisati Teret za dodavanje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Selektovati Teret za brisanje:";
            // 
            // textBoxNoviTeretUN
            // 
            this.textBoxNoviTeretUN.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxNoviTeretUN.ForeColor = System.Drawing.Color.White;
            this.textBoxNoviTeretUN.Location = new System.Drawing.Point(230, 677);
            this.textBoxNoviTeretUN.Name = "textBoxNoviTeretUN";
            this.textBoxNoviTeretUN.Size = new System.Drawing.Size(122, 20);
            this.textBoxNoviTeretUN.TabIndex = 94;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.buttonObrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(511, 594);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 93;
            this.buttonObrisi.Text = "OBRIŠI";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 97;
            this.label3.Text = "UN broj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 707);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Naziv tereta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 766);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "Proizvodjac:";
            // 
            // textBoxNoviTeretProizvodjac
            // 
            this.textBoxNoviTeretProizvodjac.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxNoviTeretProizvodjac.ForeColor = System.Drawing.Color.White;
            this.textBoxNoviTeretProizvodjac.Location = new System.Drawing.Point(231, 770);
            this.textBoxNoviTeretProizvodjac.Name = "textBoxNoviTeretProizvodjac";
            this.textBoxNoviTeretProizvodjac.Size = new System.Drawing.Size(264, 20);
            this.textBoxNoviTeretProizvodjac.TabIndex = 100;
            // 
            // textBoxNoviTeretNazivtereta
            // 
            this.textBoxNoviTeretNazivtereta.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxNoviTeretNazivtereta.ForeColor = System.Drawing.Color.White;
            this.textBoxNoviTeretNazivtereta.Location = new System.Drawing.Point(230, 707);
            this.textBoxNoviTeretNazivtereta.Name = "textBoxNoviTeretNazivtereta";
            this.textBoxNoviTeretNazivtereta.Size = new System.Drawing.Size(264, 20);
            this.textBoxNoviTeretNazivtereta.TabIndex = 101;
            // 
            // comboBoxKategorijeTereta
            // 
            this.comboBoxKategorijeTereta.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxKategorijeTereta.ForeColor = System.Drawing.Color.White;
            this.comboBoxKategorijeTereta.FormattingEnabled = true;
            this.comboBoxKategorijeTereta.Location = new System.Drawing.Point(231, 739);
            this.comboBoxKategorijeTereta.Name = "comboBoxKategorijeTereta";
            this.comboBoxKategorijeTereta.Size = new System.Drawing.Size(264, 21);
            this.comboBoxKategorijeTereta.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 738);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 103;
            this.label6.Text = "Kategorije Tereta:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(511, 623);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 104;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // VidiTeret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(598, 833);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxKategorijeTereta);
            this.Controls.Add(this.textBoxNoviTeretNazivtereta);
            this.Controls.Add(this.textBoxNoviTeretProizvodjac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxTeret);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNoviTeretUN);
            this.Controls.Add(this.buttonObrisi);
            this.Name = "VidiTeret";
            this.Text = "VidiTeret";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ComboBox comboBoxTeret;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoviTeretUN;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNoviTeretProizvodjac;
        private System.Windows.Forms.TextBox textBoxNoviTeretNazivtereta;
        private System.Windows.Forms.ComboBox comboBoxKategorijeTereta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEdit;
    }
}