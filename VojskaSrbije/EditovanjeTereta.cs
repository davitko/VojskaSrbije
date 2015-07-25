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
    public partial class EditovanjeTereta : Form
    {
        Form1 form1;
        VidiTeret mainFormteret;
        SQLiteConnection sqlite;

        String idtereta = "nepoznato";
        String unBr = "nepoznato";
        String kategorijaTereta = "nepoznato";
        String nazivTereta = "nepoznato";
        String proizvodjac = "nepoznato";

        public EditovanjeTereta()
        {
            InitializeComponent();
        }
        public EditovanjeTereta(Form1 form1, SQLiteConnection conn, String idtereta, String unBr, String kategorijaTereta, String nazivTereta, String proizvodjac)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            this.idtereta = idtereta;
            this.unBr = unBr;
            this.kategorijaTereta = kategorijaTereta;
            this.nazivTereta = nazivTereta;
            this.proizvodjac = proizvodjac;
            populateFields();
        }
        public EditovanjeTereta(VidiTeret form1, SQLiteConnection conn, String idtereta, String unBr, String kategorijaTereta, String nazivTereta, String proizvodjac)
        {
            InitializeComponent();
            this.mainFormteret = form1;
            sqlite = conn;
            this.idtereta = idtereta;
            this.unBr = unBr;
            this.kategorijaTereta = kategorijaTereta;
            this.nazivTereta = nazivTereta;
            this.proizvodjac = proizvodjac;
            populateFields();
        }
        public void populateFields()
        {
            SQLiteCommand nadjiImeKatT = sqlite.CreateCommand();
            nadjiImeKatT.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA;";
            SQLiteDataReader dr = nadjiImeKatT.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKategorijaTereta.Items.Add(dr.GetString(0));
            }
            dr.Close();

            textBoxUNBr.Text = unBr;
            textBoxNazivtereta.Text = nazivTereta;
            textBoxProizvodjac.Text = proizvodjac;
            comboBoxKategorijaTereta.SelectedIndex = comboBoxKategorijaTereta.FindStringExact(kategorijaTereta);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (unBr == textBoxUNBr.Text && nazivTereta == textBoxNazivtereta.Text && kategorijaTereta == comboBoxKategorijaTereta.SelectedItem.ToString() && proizvodjac == textBoxProizvodjac.Text)
            {
                MessageBox.Show("Nista niste izmenili!", "Upozorenje");
                return;
            }
            else
            {
                unBr = textBoxUNBr.Text;
                nazivTereta = textBoxNazivtereta.Text;
                kategorijaTereta = comboBoxKategorijaTereta.SelectedItem.ToString();
                proizvodjac = textBoxProizvodjac.Text;
                
                SQLiteCommand nadjiIDGrada = sqlite.CreateCommand();
                nadjiIDGrada.CommandText = "select kategorijaTID from KATEGORIJA_TERETA where nazivKatTereta=" + "'" + kategorijaTereta + "';";
                SQLiteDataReader dr2 = nadjiIDGrada.ExecuteReader();
                dr2.Read();
                int kategorijaTID = dr2.GetInt32(0);

                SQLiteCommand update = sqlite.CreateCommand();
                update.CommandText = "UPDATE TERET SET naziv='" + nazivTereta + "', proizvodjac = '" + proizvodjac + "',  UN = " + unBr + ", kategorijaID = " + kategorijaTID + "  WHERE teretID=" + idtereta + ";";
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Uspesno se azuirirali objekat na: " + unBr + " - " + kategorijaTereta + " - " + nazivTereta + " - " + proizvodjac + ".", "Obavestenje");
                    mainFormteret.populateDropDown();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nije uspelo azuriranje objekat na: " + unBr + " - " + kategorijaTereta + " - " + nazivTereta + " - " + proizvodjac + ".", "Upozorenje");
                    return;
                }
            }
        }
    }
}
