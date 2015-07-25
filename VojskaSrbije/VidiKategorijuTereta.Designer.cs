namespace VojskaSrbije
{
    partial class VidiKategorijuTereta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VidiKategorijuTereta));
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNovaKategorija = new System.Windows.Forms.TextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxKategorije = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(107, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(281, 31);
            this.label15.TabIndex = 77;
            this.label15.Text = "KATEGORIJE TERETA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 440);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Kategorije";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Naziv Kategorije Tereta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Upisati Kategoriju za dodavanje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Selektovati Kategoriju za brisanje:";
            // 
            // textBoxNovaKategorija
            // 
            this.textBoxNovaKategorija.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxNovaKategorija.ForeColor = System.Drawing.Color.White;
            this.textBoxNovaKategorija.Location = new System.Drawing.Point(220, 597);
            this.textBoxNovaKategorija.Name = "textBoxNovaKategorija";
            this.textBoxNovaKategorija.Size = new System.Drawing.Size(209, 20);
            this.textBoxNovaKategorija.TabIndex = 92;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.BackColor = System.Drawing.Color.DarkRed;
            this.buttonObrisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonObrisi.ForeColor = System.Drawing.Color.White;
            this.buttonObrisi.Location = new System.Drawing.Point(444, 524);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 91;
            this.buttonObrisi.Text = "OBRIŠI";
            this.buttonObrisi.UseVisualStyleBackColor = false;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(444, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxKategorije
            // 
            this.comboBoxKategorije.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxKategorije.ForeColor = System.Drawing.Color.White;
            this.comboBoxKategorije.FormattingEnabled = true;
            this.comboBoxKategorije.Location = new System.Drawing.Point(220, 525);
            this.comboBoxKategorije.Name = "comboBoxKategorije";
            this.comboBoxKategorije.Size = new System.Drawing.Size(209, 21);
            this.comboBoxKategorije.TabIndex = 89;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(444, 553);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 105;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // VidiKategorijuTereta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(544, 641);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNovaKategorija);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxKategorije);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VidiKategorijuTereta";
            this.Text = "VidiKategorijuTereta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNovaKategorija;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxKategorije;
        private System.Windows.Forms.Button buttonEdit;
    }
}