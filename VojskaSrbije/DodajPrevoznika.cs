using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace VojskaSrbije
{
    public partial class DodajPrevoznika : Form
    {
        DodajTransport otac;
        Form1 mainForm;
        SQLiteConnection sqlite;
        int flag = 2;
        public DodajPrevoznika()
        {
            InitializeComponent();
        }
        public DodajPrevoznika(DodajTransport form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            populateDropDown();
        }
        public DodajPrevoznika(DodajTransport form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            populateDropDown();
        }
        public DodajPrevoznika(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
            populateDropDown();
        }

        public void populateDropDown()
        {
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select imeObjekta from OBJEKAT;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxObjekti.Items.Add(dr.GetString(0));
            }

            comboBoxObjekti.SelectedIndex = 0;
        }

        public void radioButtonCheck()
        {
            if (radioButtonVojnaPostaPrevoznika.Checked)
                textBoxVojnaPosta.Enabled = true;
            else
                textBoxVojnaPosta.Enabled = false;

            if (radioButtonObjekatPrevoznika.Checked)
                comboBoxObjekti.Enabled = true;
            else
                comboBoxObjekti.Enabled = false;

        }
        public String noviObjekatIme
        {
            get { return noviObjekatIme; }
            set
            {
                comboBoxObjekti.Items.Add(value);
                comboBoxObjekti.SelectedIndex = comboBoxObjekti.Items.Count - 1;
            }
        }

        public String noviObjekatID
        {
            get { return noviObjekatID; }
            set
            {
                textBoxVojnaPosta.Text = value;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String nazivObjekta; 
            String vojnaPostaObjekta;
            SQLiteCommand nadjiIdObjekta = sqlite.CreateCommand();
            if (textBoxVojnaPosta.Enabled)
            {
                vojnaPostaObjekta = textBoxVojnaPosta.Text;  
                nadjiIdObjekta.CommandText = "select objekatID from OBJEKAT where vojnaPosta='" + vojnaPostaObjekta + "';";
            }
            if (comboBoxObjekti.Enabled)
            {
                nazivObjekta = comboBoxObjekti.Text;
                nadjiIdObjekta.CommandText = "select objekatID from OBJEKAT where imeObjekta='" + nazivObjekta + "';";
            }
            SQLiteDataReader dr = nadjiIdObjekta.ExecuteReader();
            int objekatID = -1;
            try
            {
                dr.Read();
                objekatID = dr.GetInt32(0);
            }
            catch {
                MessageBox.Show("Objekat sa trazenom Vojnom Postom ne postoji, molimo unesite ga!");
                return;
            }
            
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into PREVOZNIK (prevoznoSredstvo, registracioniBr, objekatPrevoznikaID, vozac) values ('" + textBoxPrevoznoSredstvo.Text + "', '" + textBoxRegBr.Text + "', " + objekatID + ", '" + textBoxVozac.Text + "');";
            try
            {
                add.ExecuteNonQuery();
                MessageBox.Show("Prevoznik: " + textBoxPrevoznoSredstvo.Text + " je uspešno dodat!");
                mainForm.populateTable();
                otac.populateFormForEdit();
                this.Close();
            }
            catch { }
            
           
        }

        private void buttonDodajObjekat_Click(object sender, EventArgs e)
        {
            DodajObjekat newObj = new DodajObjekat(this, sqlite, flag);
            newObj.Show();

        }

        private void radioButtonVojnaPostaPrevoznika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVojnaPostaPrevoznika.Checked)
            {
                textBoxVojnaPosta.Enabled = true; textBoxVojnaPosta.ForeColor = Color.White; textBoxVojnaPosta.BackColor = Color.DarkRed;
                comboBoxObjekti.Enabled = false; comboBoxObjekti.ForeColor = Color.DarkGray; comboBoxObjekti.BackColor = Color.Gray;
            }
            else
            { 
                textBoxVojnaPosta.Enabled = false; 
                comboBoxObjekti.Enabled = true; 
            }
        }

        private void radioButtonObjekatPrevoznika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonObjekatPrevoznika.Checked)
            {
                textBoxVojnaPosta.Enabled = false; comboBoxObjekti.Enabled = true;
            }
            else
            {
                textBoxVojnaPosta.Enabled = true; comboBoxObjekti.Enabled = false;
            }
        }
    }
}
