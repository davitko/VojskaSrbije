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
    public partial class EditovanjeRelacije : Form
    {
        Form1 form1;
        VidiRelaciju mainFormRelacija;
        SQLiteConnection sqlite;

        int idRelacije = -1;
        String imePosiljaoca = "nepoznato";
        String incialImePosiljaoca = "nepoznato";
        String gradPosiljaoca = "nepoznato";
        String imePrimaoca = "nepoznato";
        String incialImePrimaoca = "nepoznato";
        String gradPrimaoca = "nepoznato";
        String vremeUtovara = "nepoznato";
        String vremeIstvaora = "nepoznato";

        public EditovanjeRelacije()
        {
            InitializeComponent();
        }
        public EditovanjeRelacije(Form1 form1, SQLiteConnection conn, int idRelacije, String imePosiljaoca, String gradPosiljaoca, String imePrimaoca, String gradPrimaoca, String vremeUtovara, String vremeIstvaora)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            this.idRelacije = idRelacije;
            this.imePosiljaoca = imePosiljaoca;
            this.incialImePosiljaoca = imePosiljaoca;
            this.imePrimaoca = imePrimaoca;
            this.incialImePrimaoca = imePrimaoca;
            this.vremeUtovara = vremeUtovara;
            this.vremeIstvaora = vremeIstvaora;
            populateFields();
        }
        public EditovanjeRelacije(VidiRelaciju form1, SQLiteConnection conn, int idRelacije, String imePosiljaoca, String gradPosiljaoca, String imePrimaoca, String gradPrimaoca, String vremeUtovara, String vremeIstvaora)
        {
            InitializeComponent();
            this.mainFormRelacija = form1;
            sqlite = conn;
            this.idRelacije = idRelacije;
            this.imePosiljaoca = imePosiljaoca;
            this.incialImePosiljaoca = imePosiljaoca;
            this.gradPosiljaoca = gradPosiljaoca;
            this.imePrimaoca = imePrimaoca;
            this.incialImePrimaoca = imePrimaoca;
            this.gradPrimaoca = gradPrimaoca;
            this.vremeUtovara = vremeUtovara;
            this.vremeIstvaora = vremeIstvaora;
            populateFields();
        }
        public void populateFields()
        {
            dateTimePickerVremeUtovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeUtovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeUtovara.ShowUpDown = true;
            dateTimePickerVremeIstovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeIstovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeIstovara.ShowUpDown = true;

            SQLiteCommand nadjiImeGrada = sqlite.CreateCommand();
            nadjiImeGrada.CommandText = "select imeObjekta from OBJEKAT;";
            SQLiteDataReader dr = nadjiImeGrada.ExecuteReader();
            while (dr.Read())
            {
                comboBoxPosiljalac.Items.Add(dr.GetString(0));
                comboBoxPrimilac.Items.Add(dr.GetString(0));
            }
            dr.Close();

            dateTimePickerVremeUtovara.Value = DateTime.Parse(vremeUtovara);
            dateTimePickerVremeIstovara.Value = DateTime.Parse(vremeIstvaora);
            comboBoxPosiljalac.SelectedIndex = comboBoxPrimilac.FindStringExact(imePosiljaoca);
            comboBoxPrimilac.SelectedIndex = comboBoxPrimilac.FindStringExact(imePrimaoca);
            labelGradPosiljaoca.Text = " - " + gradPosiljaoca;
            labelGradPrimaoca.Text = " - " + gradPrimaoca;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (vremeUtovara == dateTimePickerVremeUtovara.Text && vremeIstvaora == dateTimePickerVremeIstovara.Text && incialImePosiljaoca == comboBoxPosiljalac.SelectedItem.ToString() && incialImePrimaoca == comboBoxPrimilac.SelectedItem.ToString())
            {
                MessageBox.Show("Nista niste izmenili!", "Upozorenje");
                return;
            }
            else
            {
                imePosiljaoca = comboBoxPosiljalac.SelectedItem.ToString();
                imePrimaoca = comboBoxPrimilac.SelectedItem.ToString();
                vremeUtovara = dateTimePickerVremeUtovara.Text;
                vremeIstvaora = dateTimePickerVremeIstovara.Text;

                SQLiteCommand nadjiIdPosiljaoca = sqlite.CreateCommand();
                nadjiIdPosiljaoca.CommandText = "select objekatID from OBJEKAT where imeObjekta = '" + imePosiljaoca + "';";
                SQLiteDataReader dr = nadjiIdPosiljaoca.ExecuteReader();
                dr.Read();
                int IdPosiljaoca = dr.GetInt32(0);
                dr.Close();

                SQLiteCommand nadjiIdPrimaoca = sqlite.CreateCommand();
                nadjiIdPrimaoca.CommandText = "select objekatID from OBJEKAT where imeObjekta = '" + imePrimaoca + "';";
                dr = nadjiIdPrimaoca.ExecuteReader();
                dr.Read();
                int IdPrimaoca = dr.GetInt32(0);
                dr.Close();

                SQLiteCommand update = sqlite.CreateCommand();
                update.CommandText = "UPDATE RELACIJA_KRETANJA SET utovarID=" + IdPosiljaoca + ", istovarID = " + IdPrimaoca + ",  vremeUtovara = '" + vremeUtovara + "', vremeIstovara = '" + vremeIstvaora + "' WHERE relacijaID=" + idRelacije + ";";
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Uspesno se azuirirali Relaciju na od: '" + imePosiljaoca + "' do: '" + imePrimaoca + "'.", "Obavestenje");
                    mainFormRelacija.populateDropDown();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nije uspelo azuriranje Relaciju na od: '" + imePosiljaoca + "' do: '" + imePrimaoca + "'.", "Obavestenje");
                    return;
                }
            }
        }

        private void comboBoxPosiljalac_SelectedIndexChanged(object sender, EventArgs e)
        {
            imePosiljaoca = comboBoxPosiljalac.SelectedItem.ToString();
            SQLiteCommand nadjiIdGrada = sqlite.CreateCommand();
            nadjiIdGrada.CommandText = "select gradID from OBJEKAT where imeObjekta = '" + imePosiljaoca + "';";
            SQLiteDataReader dr = nadjiIdGrada.ExecuteReader();
            dr.Read();
            int IdGrada = dr.GetInt32(0);
            dr.Close();
            SQLiteCommand nadjiImeGrada = sqlite.CreateCommand();
            nadjiImeGrada.CommandText = "select imeGrada from GRAD where gradID = " + IdGrada + ";";
            dr = nadjiImeGrada.ExecuteReader();
            dr.Read();
            String nazivGrada = dr.GetString(0);
            dr.Close();
            labelGradPosiljaoca.Text = " - " + nazivGrada;
            
        }

        private void comboBoxPrimilac_SelectedIndexChanged(object sender, EventArgs e)
        {
            imePrimaoca = comboBoxPrimilac.SelectedItem.ToString();
            SQLiteCommand nadjiIdGrada = sqlite.CreateCommand();
            nadjiIdGrada.CommandText = "select gradID from OBJEKAT where imeObjekta = '" + imePrimaoca + "';";
            SQLiteDataReader dr = nadjiIdGrada.ExecuteReader();
            dr.Read();
            int IdGrada = dr.GetInt32(0);
            dr.Close();
            SQLiteCommand nadjiImeGrada = sqlite.CreateCommand();
            nadjiImeGrada.CommandText = "select imeGrada from GRAD where gradID = " + IdGrada + ";";
            dr = nadjiImeGrada.ExecuteReader();
            dr.Read();
            String nazivGrada = dr.GetString(0);
            dr.Close();
            labelGradPrimaoca.Text = " - " + nazivGrada;
        }

       
    }
}
