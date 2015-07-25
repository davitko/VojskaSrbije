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
    public partial class EditObjekta : Form
    {
        Form1 form1;
        VidiObjekat mainFormObjekat;
        SQLiteConnection sqlite;

        String idObj = "nepoznato";
        String imeObj = "nepoznato";
        String vojnaPosta = "nepoznato";
        String imeGrada = "nepoznato";
        String telefon = "nepoznato";
        String faks = "nepoznato";

        public EditObjekta()
        {
            InitializeComponent();
        }
        public EditObjekta(Form1 form1, SQLiteConnection conn, String idObj, String imeObj, String vojnaPosta, String imeGrada, String telefon, String faks)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            this.idObj = idObj;
            this.imeObj = imeObj;
            this.vojnaPosta = vojnaPosta;
            this.imeGrada = imeGrada;
            this.telefon = telefon;
            this.faks = faks;
            populateFields();
        }
        public EditObjekta(VidiObjekat formObjekat, SQLiteConnection conn, String idObj, String imeObj, String vojnaPosta, String imeGrada, String telefon, String faks)
        {
            InitializeComponent();
            this.mainFormObjekat = formObjekat;
            sqlite = conn;
            this.idObj = idObj;
            this.imeObj = imeObj;
            this.vojnaPosta = vojnaPosta;
            this.imeGrada = imeGrada;
            this.telefon = telefon;
            this.faks = faks;
            populateFields();
        }
        public void populateFields()
        {
            SQLiteCommand nadjiImeGrada = sqlite.CreateCommand();
            nadjiImeGrada.CommandText = "select imeGrada from GRAD;";
            SQLiteDataReader dr = nadjiImeGrada.ExecuteReader();
            while (dr.Read())
            {
                comboBoxGradovi.Items.Add(dr.GetString(0));
            }
            dr.Close();

            textBoxImeObjekta.Text = imeObj;
            textBoxVojnaPosta.Text = vojnaPosta;
            comboBoxGradovi.SelectedIndex = comboBoxGradovi.FindStringExact(imeGrada);    
            textBoxTelefon.Text = telefon;
            textBoxFaks.Text = faks;            
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (imeObj == textBoxImeObjekta.Text && vojnaPosta == textBoxVojnaPosta.Text && imeGrada == comboBoxGradovi.SelectedItem.ToString() && telefon == textBoxTelefon.Text && faks == textBoxFaks.Text)
            {
                MessageBox.Show("Nista niste izmenili!", "Upozorenje");
                return;
            }
            else
            {
                imeObj = textBoxImeObjekta.Text;
                vojnaPosta = textBoxVojnaPosta.Text;
                imeGrada = comboBoxGradovi.SelectedItem.ToString();
                telefon = textBoxTelefon.Text;
                faks = textBoxFaks.Text;

                SQLiteCommand nadjiIDGrada = sqlite.CreateCommand();
                nadjiIDGrada.CommandText = "select gradID from GRAD where imeGrada=" + "'" + imeGrada + "';";
                SQLiteDataReader dr2 = nadjiIDGrada.ExecuteReader();
                dr2.Read();
                int gradID = dr2.GetInt32(0);

                SQLiteCommand update = sqlite.CreateCommand();
                update.CommandText = "UPDATE OBJEKAT SET imeObjekta='" + imeObj + "', vojnaPosta = '" + vojnaPosta + "',  gradID = " + gradID + ", telefon = " + telefon + ", faks =" + faks + " WHERE objekatID=" + idObj + ";";
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Uspesno se azuirirali objekat na: " + imeObj + " - " + vojnaPosta + " - " + imeGrada + " - " + telefon + " - " + faks + ".", "Obavestenje");
                    mainFormObjekat.populateDropDown();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nije uspelo azuriranje objekat na: " + imeObj + " - " + vojnaPosta + " - " + imeGrada + " - " + telefon + " - " + faks + ".", "Upozorenje");
                    return;
                }
            }
        }
    }
}
