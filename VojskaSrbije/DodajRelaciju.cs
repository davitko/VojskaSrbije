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
    public partial class DodajRelaciju : Form
    {
        DodajTransport otac;
        Form1 mainForm;
        SQLiteConnection sqlite;

        public DodajRelaciju()
        {
            InitializeComponent();
        }
         public DodajRelaciju(DodajTransport form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            populateDropDown();
            dataTimePickerFormt();
        }
         public DodajRelaciju(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
            populateDropDown();
            dataTimePickerFormt();
        }
         public void populateDropDown()
         {
             SQLiteCommand all = sqlite.CreateCommand();
             all.CommandText = "select imeObjekta from OBJEKAT;";
             SQLiteDataReader dr = all.ExecuteReader();
             while (dr.Read())
             {
                 comboBoxPosiljalac.Items.Add(dr.GetString(0));
                 comboBoxPrimilac.Items.Add(dr.GetString(0));
             }

             comboBoxPosiljalac.SelectedIndex = 0;
             comboBoxPrimilac.SelectedIndex = 0;

         }
        public void dataTimePickerFormt()
         {
             dateTimePickerVremeUtovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
             dateTimePickerVremeUtovara.Format = DateTimePickerFormat.Custom;
             dateTimePickerVremeUtovara.ShowUpDown = true;

             dateTimePickerVremeIstovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
             dateTimePickerVremeIstovara.Format = DateTimePickerFormat.Custom;
             dateTimePickerVremeIstovara.ShowUpDown = true;
         }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String posiljalac = comboBoxPosiljalac.Text;
            String primalac = comboBoxPrimilac.Text;

            SQLiteCommand nadjiPosiljalacID = sqlite.CreateCommand();
            nadjiPosiljalacID.CommandText = "select objekatID from OBJEKAT where imeObjekta='" + posiljalac + "';";
            SQLiteDataReader dr = nadjiPosiljalacID.ExecuteReader();
            int posiljalacID = -1;
            try
            {
                dr.Read();
                posiljalacID = dr.GetInt32(0);
            }
            catch
            {
                MessageBox.Show("Ne možemo da nađemo Pošiljaoca!");
                return;
            }

            SQLiteCommand nadjiPrimalacID = sqlite.CreateCommand();
            nadjiPrimalacID.CommandText = "select objekatID from OBJEKAT where imeObjekta='" + primalac + "';";
            dr = nadjiPrimalacID.ExecuteReader();
            int primalacID = -1;
            try
            {
                dr.Read();
                primalacID = dr.GetInt32(0);
            }
            catch
            {
                MessageBox.Show("Ne možemo da nađemo Primaoca!");
                return;
            }

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into RELACIJA_KRETANJA (utovarID, istovarID, vremeUtovara, vremeIstovara) values (" + posiljalacID + ", " + primalacID + ", '" + dateTimePickerVremeUtovara.Text + "', '" + dateTimePickerVremeIstovara.Text + "');";
            add.ExecuteNonQuery();

            MessageBox.Show("Relacija od: " + posiljalac + " do " + primalac + "je uspešno dodata!");
            this.Close();
        }

        private void dateTimePickerVremeUtovara_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
