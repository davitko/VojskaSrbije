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
    public partial class VidiRelaciju : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;

        public VidiRelaciju()
        {
            InitializeComponent();
        }
        public VidiRelaciju(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }
        public void populateDropDown()
        {
            dataGridView1.Rows.Clear();
            comboBoxObjektiIstovara.Items.Clear();
            comboBoxObjektiUtovara.Items.Clear();
            comboBoxRelacije.Items.Clear();
            dateTimePickerVremeUtovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeUtovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeUtovara.ShowUpDown = true;
            dateTimePickerVremeIstovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeIstovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeIstovara.ShowUpDown = true;

            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select relacijaID, utovarID, istovarID, vremeUtovara, vremeIstovara from RELACIJA_KRETANJA;";
            SQLiteDataReader dr = all.ExecuteReader();
            int relacijaID = -1;
            String relacija = "nepoznato";
            String objekatUtovara = "nepoznato";
            String objekatIstovara = "nepoznato";
            String mestoUtovara = "nepoznato";
            String mestoIstovara = "nepoznato";
            int mestoIDUtovara = -1;
            int mestoIDIstovara = -1;
            while (dr.Read())
            {
                relacijaID = dr.GetInt32(0);
                SQLiteCommand nazivObjektaUtovara = sqlite.CreateCommand();
                nazivObjektaUtovara.CommandText = "select imeObjekta, gradID from OBJEKAT where objekatID= " + dr.GetInt32(1) + ";";
                SQLiteDataReader dr2 = nazivObjektaUtovara.ExecuteReader();
                dr2.Read();
                objekatUtovara = dr2.GetString(0);
                mestoIDUtovara = dr2.GetInt32(1);

                SQLiteCommand nazivObjektaIstovara = sqlite.CreateCommand();
                nazivObjektaIstovara.CommandText = "select imeObjekta, gradID from OBJEKAT where objekatID= " + dr.GetInt32(2) + ";";
                dr2 = nazivObjektaIstovara.ExecuteReader();
                dr2.Read();
                objekatIstovara = dr2.GetString(0);
                mestoIDIstovara = dr2.GetInt32(1);

                SQLiteCommand nazivMestaUtovara = sqlite.CreateCommand();
                nazivMestaUtovara.CommandText = "select imeGrada from GRAD where gradID= " + mestoIDUtovara + ";";
                dr2 = nazivMestaUtovara.ExecuteReader();
                dr2.Read();
                mestoUtovara = dr2.GetString(0);

                SQLiteCommand nazivMestaIstovara = sqlite.CreateCommand();
                nazivMestaIstovara.CommandText = "select imeGrada from GRAD where gradID= " + mestoIDIstovara + ";";
                dr2 = nazivMestaIstovara.ExecuteReader();
                dr2.Read();
                mestoIstovara = dr2.GetString(0);
                
                relacija = Convert.ToString(dr.GetInt32(0)) + "." + objekatUtovara + "-" + objekatIstovara;
                //relacija = Convert.ToString(dr.GetInt32(0));
                comboBoxRelacije.Items.Add(relacija);
                dataGridView1.Rows.Add(relacijaID, objekatUtovara, mestoUtovara, objekatIstovara, mestoIstovara, dr.GetString(3), dr.GetString(4));
            }
            dr.Close();
            SQLiteCommand allObj = sqlite.CreateCommand();
            allObj.CommandText = "select imeObjekta from OBJEKAT;";
            dr = allObj.ExecuteReader();
            while (dr.Read())
            {
                comboBoxObjektiUtovara.Items.Add(dr.GetString(0));
                comboBoxObjektiIstovara.Items.Add(dr.GetString(0));
            }
            comboBoxObjektiIstovara.SelectedIndex = -1;
            comboBoxObjektiUtovara.SelectedIndex = -1;
            comboBoxRelacije.SelectedIndex = -1;
            dr.Close();
        }
        private void deleteItem(String deleted)
        {
            SQLiteCommand deleteRelacija = sqlite.CreateCommand();
            deleteRelacija.CommandText = "DELETE FROM RELACIJA_KRETANJA WHERE relacijaID='" + deleted + "';";
            try
            {
                deleteRelacija.ExecuteNonQuery();
                MessageBox.Show("Uspesno je obrisana relacija sa ID: " + deleted);
                populateDropDown();
            }
            catch
            {
                MessageBox.Show("Dogodila se greska prilikom brisanja relacije!", "Paznja!");
                populateDropDown();
            }
        }
        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            String deleted = "nepoznato";
            String objUtovara = "nepoznato";
            String objIstovara = "nepoznato";
            if (comboBoxRelacije.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    deleted = Convert.ToString(selectedRow.Cells[0].Value);
                    objUtovara = Convert.ToString(selectedRow.Cells[1].Value);
                    objIstovara = Convert.ToString(selectedRow.Cells[3].Value);

                    DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete Relaciju: " + deleted + ". " + objUtovara + " - " + objIstovara + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        deleteItem(deleted);
                        return;

                    }
                    else if (dr == DialogResult.No)
                    {
                        comboBoxRelacije.SelectedIndex = -1;
                        return;
                    }
                }
            }
            else
            {
                String deletedString = comboBoxRelacije.SelectedItem.ToString();
                char[] delimiterChars = { ' ', '.', '-'};
                string[] words = deletedString.Split(delimiterChars);
                deleted = words[0];
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete Relaciju sa ID: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    deleteItem(deleted);
                    return;
                }
                else if (dr == DialogResult.No)
                {
                    comboBoxRelacije.SelectedIndex = -1;
                    return;
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String objekatUtovara = "nepoznato";
            String objekatIstovara = "nepoznato";
            String vremeUtovara;
            String vremeIstovara;
   
            int objekatIDUtovara = -1;
            int objekatIDIstovara = -1;

            objekatUtovara = comboBoxObjektiUtovara.SelectedItem.ToString();
            objekatIstovara = comboBoxObjektiIstovara.SelectedItem.ToString();
            vremeUtovara = dateTimePickerVremeUtovara.Text;
            vremeIstovara = dateTimePickerVremeIstovara.Text;
            
            SQLiteCommand nadjiIDObjekta = sqlite.CreateCommand();
            nadjiIDObjekta.CommandText = "select objekatID from OBJEKAT where imeObjekta=" + "'" + objekatUtovara + "';";
            SQLiteDataReader dr2 = nadjiIDObjekta.ExecuteReader();
            dr2.Read();
            objekatIDUtovara = dr2.GetInt32(0);
            dr2.Close();
            nadjiIDObjekta.CommandText = "select objekatID from OBJEKAT where imeObjekta=" + "'" + objekatIstovara + "';";
            dr2 = nadjiIDObjekta.ExecuteReader();
            dr2.Read();
            objekatIDIstovara = dr2.GetInt32(0);
            
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into RELACIJA_KRETANJA (utovarID, istovarID, vremeUtovara, vremeIstovara) values (" + objekatIDUtovara + ", " + objekatIDIstovara + ", '" + vremeUtovara + "', '" + vremeIstovara + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Relacija Kretanja od: " + objekatUtovara + " do:" + objekatIstovara + " sa vremenom poslaska: " + vremeUtovara + " je uspešno dodata!");
            comboBoxObjektiUtovara.SelectedIndex = -1;
            comboBoxObjektiIstovara.SelectedIndex = -1;
            dateTimePickerVremeUtovara.ResetText();
            dateTimePickerVremeIstovara.ResetText();
            populateDropDown();
            dr2.Close();
        }

       private void buttonEdit_Click(object sender, EventArgs e)
        {
            int idRelacije = -1;
            String imePosiljaoca = "nepoznato";
            String gradPosiljaoca = "nepoznato";
            String imePrimaoca = "nepoznato";
            String gradPrimaoca = "nepoznato";
            String vremeUtovara = "nepoznato";
            String vremeIstvaora = "nepoznato";

            if (comboBoxRelacije.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    idRelacije = Convert.ToInt32(selectedRow.Cells[0].Value);
                    imePosiljaoca = Convert.ToString(selectedRow.Cells[1].Value);
                    gradPosiljaoca = Convert.ToString(selectedRow.Cells[2].Value);
                    imePrimaoca = Convert.ToString(selectedRow.Cells[3].Value);
                    gradPrimaoca = Convert.ToString(selectedRow.Cells[4].Value);
                    vremeUtovara = Convert.ToString(selectedRow.Cells[5].Value);
                    vremeIstvaora = Convert.ToString(selectedRow.Cells[6].Value);

                    EditovanjeRelacije editRel = new EditovanjeRelacije(this, sqlite, idRelacije, imePosiljaoca, gradPosiljaoca, imePrimaoca, gradPrimaoca, vremeUtovara, vremeIstvaora);
                    editRel.Show();
                }
            }
            else
            {
                String deletedString = comboBoxRelacije.SelectedItem.ToString();
                char[] delimiterChars = { '.', '-' };
                string[] words = deletedString.Split(delimiterChars);
                idRelacije = Convert.ToInt32(words[0]);
                imePosiljaoca = words[1];
                imePrimaoca = words[2];

                SQLiteCommand nadjiRelacijuPodaci = sqlite.CreateCommand();
                nadjiRelacijuPodaci.CommandText = "select vremeUtovara, vremeIstovara from RELACIJA_KRETANJA where relacijaID = " + idRelacije + ";";
                SQLiteDataReader dr = nadjiRelacijuPodaci.ExecuteReader();
                dr.Read();
                vremeUtovara = dr.GetString(0);
                vremeIstvaora = dr.GetString(1);
                dr.Close();
                SQLiteCommand nadjiGradIDPosiljaoca = sqlite.CreateCommand();
                nadjiGradIDPosiljaoca.CommandText = "select objekatID from OBJEKAT where imeObjekta = '" + imePosiljaoca + "';";
                dr = nadjiGradIDPosiljaoca.ExecuteReader();
                dr.Read();
                int gradIdPosiljaoca = dr.GetInt32(0);
                dr.Close();
                SQLiteCommand nadjiGradIDPrimaoca = sqlite.CreateCommand();
                nadjiGradIDPrimaoca.CommandText = "select objekatID from OBJEKAT where imeObjekta = '" + imePrimaoca + "';";
                dr = nadjiGradIDPrimaoca.ExecuteReader();
                dr.Read();
                int gradIDPrimaoca = dr.GetInt32(0);
                dr.Close();
                SQLiteCommand nadjiImeGradaPosiljaoca = sqlite.CreateCommand();
                nadjiImeGradaPosiljaoca.CommandText = "select imeGrada from GRAD where gradID = " + gradIdPosiljaoca + ";";
                dr = nadjiImeGradaPosiljaoca.ExecuteReader();
                dr.Read();
                gradPosiljaoca = dr.GetString(0);
                dr.Close();
                SQLiteCommand nadjiImeGradaPrimaoca = sqlite.CreateCommand();
                nadjiImeGradaPrimaoca.CommandText = "select imeGrada from GRAD where gradID = " + gradIDPrimaoca + ";";
                dr = nadjiImeGradaPrimaoca.ExecuteReader();
                dr.Read();
                gradPrimaoca = dr.GetString(0);
                dr.Close();

                EditovanjeRelacije editRel = new EditovanjeRelacije(this, sqlite, idRelacije, imePosiljaoca, gradPosiljaoca, imePrimaoca, gradPrimaoca, vremeUtovara, vremeIstvaora);
                editRel.Show();
                
            }
        }

       private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
           int idRelacije = -1;
           String imePosiljaoca = "nepoznato";
           String gradPosiljaoca = "nepoznato";
           String imePrimaoca = "nepoznato";
           String gradPrimaoca = "nepoznato";
           String vremeUtovara = "nepoznato";
           String vremeIstvaora = "nepoznato";

           int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
           DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
           idRelacije = Convert.ToInt32(selectedRow.Cells[0].Value);
           imePosiljaoca = Convert.ToString(selectedRow.Cells[1].Value);
           gradPosiljaoca = Convert.ToString(selectedRow.Cells[2].Value);
           imePrimaoca = Convert.ToString(selectedRow.Cells[3].Value);
           gradPrimaoca = Convert.ToString(selectedRow.Cells[4].Value);
           vremeUtovara = Convert.ToString(selectedRow.Cells[5].Value);
           vremeIstvaora = Convert.ToString(selectedRow.Cells[6].Value);

           EditovanjeRelacije editRel = new EditovanjeRelacije(this, sqlite, idRelacije, imePosiljaoca, gradPosiljaoca, imePrimaoca, gradPrimaoca, vremeUtovara, vremeIstvaora);
           editRel.Show();
       }
    }
}
