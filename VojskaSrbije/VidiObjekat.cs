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
    public partial class VidiObjekat : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;

        public VidiObjekat()
        {
            InitializeComponent();
        }
        public VidiObjekat(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }
        public void populateDropDown()
        {
            dataGridView1.Rows.Clear();
            comboBoxGradovi.Items.Clear();
            comboBoxObjekti.Items.Clear();
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select objekatID, imeObjekta, vojnaPosta, gradID, telefon, faks from OBJEKAT;";
            SQLiteDataReader dr = all.ExecuteReader();

            int objekatID = -1;
            String vojnaPosta = "nepoznato";
            int gradID = -1;
            String imeObjekta = "nepoznato";
            String imeGrada = "nepoznato";
            String telefon = "nepoznato";
            String faks = "nepoznato";
            while (dr.Read())
            {
                imeObjekta = dr.GetString(1);
                comboBoxObjekti.Items.Add(imeObjekta);
                gradID = dr.GetInt32(3);
                SQLiteCommand nazivGrada = sqlite.CreateCommand();
                nazivGrada.CommandText = "select imeGrada from GRAD where gradID=" + gradID + ";";
                SQLiteDataReader dr2 = nazivGrada.ExecuteReader();
                dr2.Read();
                imeGrada = dr2.GetString(0);
                comboBoxGradovi.Items.Add(imeGrada);
                objekatID = dr.GetInt32(0);
                try
                {
                    vojnaPosta = Convert.ToString(dr.GetInt32(2));
                }
                catch { }
                try
                {
                    telefon = dr.GetString(4);
                }
                catch { }
                try
                {
                    faks = dr.GetString(5);
                }
                catch { }
                dataGridView1.Rows.Add(objekatID, imeObjekta, vojnaPosta, imeGrada, telefon, faks);
            }
            comboBoxObjekti.SelectedIndex = -1;
            comboBoxGradovi.SelectedIndex = -1;
            dr.Close();
        }
        private void deleteItem(String deleted)
        {
            SQLiteCommand deleteObjekat = sqlite.CreateCommand();
            deleteObjekat.CommandText = "DELETE FROM OBJEKAT WHERE imeObjekta='" + deleted + "';";
            try
            {
                deleteObjekat.ExecuteNonQuery();
                MessageBox.Show("Uspesno je obrisan objekat: " + deleted);
                populateDropDown();
            }
            catch
            {
                MessageBox.Show("Dogodila se greska prilikom brisanja objekta!", "Paznja!");
                populateDropDown();
            }
                       
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            String deleted = "nepoznato";
            if (comboBoxObjekti.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    deleted = Convert.ToString(selectedRow.Cells[1].Value);

                    DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete objekat: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

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
                        comboBoxObjekti.SelectedIndex = -1;
                        return;
                    }

                }
            }
            else
            {
                deleted = comboBoxObjekti.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete grad: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

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
                    comboBoxObjekti.SelectedIndex = -1;
                    return;
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            int vojnaPosta = -1;
            int gradID = -1;
            String imeObjekta = "nepoznato";
            String imeGrada = "nepoznato";
            String telefon = "nepoznato";
            String faks = "nepoznato";

            imeObjekta = textBoxImeObjekta.Text;
            imeGrada = comboBoxGradovi.SelectedItem.ToString();
            try {
                vojnaPosta = Convert.ToInt32(textBoxVojnaPosta.Text);
            }
            catch {
                MessageBox.Show("Vojna posta mora biti ceo broj!");
            }
            telefon = textBoxTelefon.Text;
            faks = textBoxFaks.Text;
            
            SQLiteCommand nadjiIDGrada = sqlite.CreateCommand();
            nadjiIDGrada.CommandText = "select gradID from GRAD where imeGrada=" + "'" + imeGrada + "';";
            SQLiteDataReader dr2 = nadjiIDGrada.ExecuteReader();
            dr2.Read();
            gradID = dr2.GetInt32(0);
           
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into OBJEKAT (imeObjekta, vojnaPosta, gradID, telefon, faks) values ('" + imeObjekta + "', " + vojnaPosta + ", " + gradID + ", '" + telefon + "', '" + faks + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Objekat: " + imeObjekta + " je uspešno dodat!");
            textBoxImeObjekta.ResetText();
            textBoxVojnaPosta.ResetText();
            textBoxTelefon.ResetText();
            textBoxFaks.ResetText();
            populateDropDown();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String idObj = "nepoznato";
            String imeObj = "nepoznato";
            String vojnaPosta = "nepoznato";
            String imeGrada = "nepoznato";
            String telefon = "nepoznato";
            String faks = "nepoznato";
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            idObj = Convert.ToString(selectedRow.Cells[0].Value);
            imeObj = Convert.ToString(selectedRow.Cells[1].Value);
            vojnaPosta = Convert.ToString(selectedRow.Cells[2].Value);
            imeGrada = Convert.ToString(selectedRow.Cells[3].Value);
            telefon = Convert.ToString(selectedRow.Cells[4].Value);
            faks = Convert.ToString(selectedRow.Cells[5].Value);

            EditObjekta editGrad = new EditObjekta(this, sqlite, idObj, imeObj, vojnaPosta, imeGrada, telefon, faks);
            editGrad.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            String idObj = "nepoznato";
            String imeObj = "nepoznato";
            String vojnaPosta = "nepoznato";
            String imeGrada = "nepoznato";
            String telefon = "nepoznato";
            String faks = "nepoznato";
            if (comboBoxObjekti.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    idObj = Convert.ToString(selectedRow.Cells[0].Value);
                    imeObj = Convert.ToString(selectedRow.Cells[1].Value);
                    vojnaPosta = Convert.ToString(selectedRow.Cells[2].Value);
                    imeGrada = Convert.ToString(selectedRow.Cells[3].Value);
                    telefon = Convert.ToString(selectedRow.Cells[4].Value);
                    faks = Convert.ToString(selectedRow.Cells[5].Value);

                    EditObjekta editGrad = new EditObjekta(this, sqlite, idObj, imeObj, vojnaPosta, imeGrada, telefon, faks);
                    editGrad.Show();
                }
            }
            else
            {
                SQLiteCommand nadjiIObj = sqlite.CreateCommand();
                nadjiIObj.CommandText = "select objekatID, vojnaPosta, gradID, telefon, faks  from OBJEKAT where imeObjekta ='" + comboBoxObjekti.SelectedItem.ToString() + "';";
                SQLiteDataReader dr = nadjiIObj.ExecuteReader();
                dr.Read();
                idObj = Convert.ToString(dr.GetInt32(0));
                imeObj = comboBoxObjekti.SelectedItem.ToString();
                try
                {
                    vojnaPosta = Convert.ToString(dr.GetInt32(1));
                }
                catch { }
                int gradID = dr.GetInt32(2);
                try
                {
                    telefon = dr.GetString(3);
                }
                catch { }
                try
                {
                    faks = dr.GetString(3);
                }
                catch { }
                dr.Close();

                SQLiteCommand nadjiImeGrada = sqlite.CreateCommand();
                nadjiImeGrada.CommandText = "select imeGrada from GRAD where gradID =" + gradID + ";";
                dr = nadjiImeGrada.ExecuteReader();
                dr.Read();
                imeGrada = dr.GetString(0);
                dr.Close();
                
                EditObjekta editGrad = new EditObjekta(this, sqlite, idObj, imeObj, vojnaPosta, imeGrada, telefon, faks);
                editGrad.Show();
            }
        }
    }
}
