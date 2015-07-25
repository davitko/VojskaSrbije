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
    public partial class EditKategorijeTereta : Form
    {
        Form1 form1;
        VidiKategorijuTereta mainFormKat;
        SQLiteConnection sqlite;

        int idKat = -1;
        String imeKat = "nepoznato";
      
        public EditKategorijeTereta()
        {
            InitializeComponent();
        }
        public EditKategorijeTereta(Form1 form1, SQLiteConnection conn, int idKat, String imeKat)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            this.idKat = idKat;
            this.imeKat = imeKat;
            populateFields();
        }
        public EditKategorijeTereta(VidiKategorijuTereta form1, SQLiteConnection conn, int idKat, String imeKat)
        {
            InitializeComponent();
            this.mainFormKat = form1;
            sqlite = conn;
            this.idKat = idKat;
            this.imeKat = imeKat;
            populateFields();
        }
        public void populateFields()
        {
            textBoxImeKategorije.Text = imeKat;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (imeKat == textBoxImeKategorije.Text )
            {
                MessageBox.Show("Nista niste izmenili!", "Upozorenje");
                return;
            }
            else
            {
                //imeKat = textBoxImeKategorije.Text;
            
                SQLiteCommand update = sqlite.CreateCommand();
                update.CommandText = "UPDATE KATEGORIJA_TERETA SET nazivKatTereta='" + textBoxImeKategorije.Text +"' WHERE kategorijaTID=" + idKat + ";";
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Uspesno se azuirirali KATEGORIJA TERETA sa: '" + imeKat + "' na: '" + textBoxImeKategorije.Text + "'.", "Obavestenje");
                    mainFormKat.populateDropDown();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nije uspelo azuriranje KATEGORIJA TERETA sa: '" + imeKat + "' na: '" + textBoxImeKategorije.Text + "'.", "Obavestenje");
                    return;
                }
            }
        }
    }
}
