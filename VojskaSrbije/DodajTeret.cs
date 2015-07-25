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
    public partial class DodajTeret : Form
    {
        DodajTransport otac;
        Form1 mainForm;
        SQLiteConnection sqlite;

        public DodajTeret()
        {
            InitializeComponent();
        }
        public DodajTeret(DodajTransport form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            populateKategorijateretaDropDown();
        }
         public DodajTeret(DodajTransport form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            populateKategorijateretaDropDown();
        }
         public DodajTeret(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
            populateKategorijateretaDropDown();
        }
         public void populateKategorijateretaDropDown()
         {
             SQLiteCommand all = sqlite.CreateCommand();
             all.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA;";
             SQLiteDataReader dr = all.ExecuteReader();
             while (dr.Read())
             {
                 comboBoxKategorijaTereta.Items.Add(dr.GetString(0));
             }
             comboBoxKategorijaTereta.SelectedIndex = 0;
         }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String kategorijaTereta = comboBoxKategorijaTereta.Text;
            SQLiteCommand nadjiKatT = sqlite.CreateCommand();
            nadjiKatT.CommandText = "select kategorijaTID from KATEGORIJA_TERETA where nazivKatTereta='" + kategorijaTereta + "';";
            SQLiteDataReader dr = nadjiKatT.ExecuteReader();
            int kategorijaID = -1;
            try
            {
                dr.Read();
                kategorijaID = dr.GetInt32(0);
            }
            catch
            {
                MessageBox.Show("Ne možemo da nađemo ovu Kategoriju!");
                return;
            }

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into TERET (UN, kategorijaID, naziv, proizvodjac) values ('" + textBoxUNBr.Text + "', " + kategorijaID + ", '" + textBoxNazivtereta.Text +"', '" + textBoxProizvodjac.Text + "');";
            try
            {
                add.ExecuteNonQuery();
                add.CommandText = @"select last_insert_rowid()";
                int teretID = Convert.ToInt32(add.ExecuteScalar());
                MessageBox.Show("Teret: " + textBoxNazivtereta.Text + " je uspešno dodat!");
                mainForm.populateTable();
                otac.populateFormForEdit();
                //otac.comboBoxTereti.Items.Add()
                otac.selectLastTeret();
                this.Close();
             }
            catch { }
               
            }
           
           
    }
}
