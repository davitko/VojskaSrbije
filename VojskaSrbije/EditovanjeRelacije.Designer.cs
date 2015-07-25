namespace VojskaSrbije
{
    partial class EditovanjeRelacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditovanjeRelacije));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxPrimilac = new System.Windows.Forms.ComboBox();
            this.comboBoxPosiljalac = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerVremeIstovara = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVremeUtovara = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelGradPosiljaoca = new System.Windows.Forms.Label();
            this.labelGradPrimaoca = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(354, 273);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 29);
            this.buttonUpdate.TabIndex = 100;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxPrimilac
            // 
            this.comboBoxPrimilac.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxPrimilac.ForeColor = System.Drawing.Color.White;
            this.comboBoxPrimilac.FormattingEnabled = true;
            this.comboBoxPrimilac.Location = new System.Drawing.Point(229, 144);
            this.comboBoxPrimilac.Name = "comboBoxPrimilac";
            this.comboBoxPrimilac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPrimilac.TabIndex = 99;
            this.comboBoxPrimilac.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrimilac_SelectedIndexChanged);
            // 
            // comboBoxPosiljalac
            // 
            this.comboBoxPosiljalac.BackColor = System.Drawing.Color.DarkRed;
            this.comboBoxPosiljalac.ForeColor = System.Drawing.Color.White;
            this.comboBoxPosiljalac.FormattingEnabled = true;
            this.comboBoxPosiljalac.Location = new System.Drawing.Point(229, 115);
            this.comboBoxPosiljalac.Name = "comboBoxPosiljalac";
            this.comboBoxPosiljalac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPosiljalac.TabIndex = 98;
            this.comboBoxPosiljalac.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosiljalac_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(130, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 97;
            this.label11.Text = "Primalac:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(122, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 96;
            this.label10.Text = "Pošiljalac:";
            // 
            // dateTimePickerVremeIstovara
            // 
            this.dateTimePickerVremeIstovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeIstovara.Location = new System.Drawing.Point(229, 218);
            this.dateTimePickerVremeIstovara.Name = "dateTimePickerVremeIstovara";
            this.dateTimePickerVremeIstovara.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVremeIstovara.TabIndex = 95;
            // 
            // dateTimePickerVremeUtovara
            // 
            this.dateTimePickerVremeUtovara.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerVremeUtovara.CalendarMonthBackground = System.Drawing.Color.DarkRed;
            this.dateTimePickerVremeUtovara.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerVremeUtovara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVremeUtovara.Location = new System.Drawing.Point(230, 191);
            this.dateTimePickerVremeUtovara.Name = "dateTimePickerVremeUtovara";
            this.dateTimePickerVremeUtovara.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerVremeUtovara.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(76, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 23);
            this.label14.TabIndex = 93;
            this.label14.Text = "Vreme istovara:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(73, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "Vreme utovara:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(138, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(304, 31);
            this.label15.TabIndex = 91;
            this.label15.Text = "EDITOVANJE RELACIJE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGradPosiljaoca
            // 
            this.labelGradPosiljaoca.AutoSize = true;
            this.labelGradPosiljaoca.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelGradPosiljaoca.ForeColor = System.Drawing.Color.White;
            this.labelGradPosiljaoca.Location = new System.Drawing.Point(437, 115);
            this.labelGradPosiljaoca.Name = "labelGradPosiljaoca";
            this.labelGradPosiljaoca.Size = new System.Drawing.Size(149, 23);
            this.labelGradPosiljaoca.TabIndex = 101;
            this.labelGradPosiljaoca.Text = "Grad Posiljaoca";
            // 
            // labelGradPrimaoca
            // 
            this.labelGradPrimaoca.AutoSize = true;
            this.labelGradPrimaoca.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelGradPrimaoca.ForeColor = System.Drawing.Color.White;
            this.labelGradPrimaoca.Location = new System.Drawing.Point(438, 144);
            this.labelGradPrimaoca.Name = "labelGradPrimaoca";
            this.labelGradPrimaoca.Size = new System.Drawing.Size(149, 23);
            this.labelGradPrimaoca.TabIndex = 102;
            this.labelGradPrimaoca.Text = "Grad Posiljaoca";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(590, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 314);
            this.vScrollBar1.TabIndex = 103;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(34, 316);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(539, 17);
            this.hScrollBar1.TabIndex = 104;
            // 
            // EditovanjeRelacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(609, 332);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.labelGradPrimaoca);
            this.Controls.Add(this.labelGradPosiljaoca);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxPrimilac);
            this.Controls.Add(this.comboBoxPosiljalac);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerVremeIstovara);
            this.Controls.Add(this.dateTimePickerVremeUtovara);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditovanjeRelacije";
            this.Text = "EditovanjeRelacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxPrimilac;
        private System.Windows.Forms.ComboBox comboBoxPosiljalac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeIstovara;
        private System.Windows.Forms.DateTimePicker dateTimePickerVremeUtovara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelGradPosiljaoca;
        private System.Windows.Forms.Label labelGradPrimaoca;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}