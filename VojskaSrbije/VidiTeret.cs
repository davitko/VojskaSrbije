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
    public partial class VidiTeret : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;

        public VidiTeret()
        {
            InitializeComponent();
        }
        public VidiTeret(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }
        public void populateDropDown()
        {
            dataGridView1.Rows.Clear();
            comboBoxKategorijeTereta.Items.Clear();
            comboBoxTeret.Items.Clear();
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select teretID, UN, kategorijaID, naziv, proizvodjac from TERET;";
            SQLiteDataReader dr = all.ExecuteReader();
            int teretID = -1;
            int unBr = -1;
            String nazivKatTereta = "nepoznato";
            String nazivTereta = "nepoznato";
            String proizvodjac = "nepoznato";
            while (dr.Read())
            {
                comboBoxTeret.Items.Add(dr.GetString(3));
                SQLiteCommand nazivKategorije = sqlite.CreateCommand();
                nazivKategorije.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA where kategorijaTID="+dr.GetInt32(2)+";";
                SQLiteDataReader dr2 = nazivKategorije.ExecuteReader();
                dr2.Read();
                teretID = dr.GetInt32(0);
                try
                {
                    unBr = dr.GetInt32(1);
                }
                catch { }
                nazivKatTereta = dr2.GetString(0);
                nazivTereta = dr.GetString(3);
                try
                {
                    proizvodjac = dr.GetString(4);
                }
                catch { }
               
                comboBoxKategorijeTereta.Items.Add(nazivKatTereta);
                dataGridView1.Rows.Add(teretID, unBr, nazivKatTereta, nazivTereta, proizvodjac);
            }
            comboBoxTeret.SelectedIndex = -1;
            comboBoxKategorijeTereta.SelectedIndex = -1;
            dr.Close();
        }
        private void deleteItem(String deleted)
        {
            SQLiteCommand deleteTeret = sqlite.CreateCommand();
            deleteTeret.CommandText = "DELETE FROM TERET WHERE naziv ='" + deleted + "';";
            deleteTeret.ExecuteNonQuery();
            //comboBoxGradovi.Items.Remove(comboBoxGradovi.SelectedItem);
            try
            {
                MessageBox.Show("Uspesno je obrisan teret: " + deleted);
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
            if (comboBoxTeret.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    deleted = Convert.ToString(selectedRow.Cells[3].Value);

                    DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete teret: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

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
                        comboBoxTeret.SelectedIndex = -1;
                        return;
                    }

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete grad: " + comboBoxTeret.SelectedText + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    deleted = comboBoxTeret.SelectedItem.ToString();
                    deleteItem(deleted);
                    return;

                }
                else if (dr == DialogResult.No)
                {
                    comboBoxTeret.SelectedIndex = -1;
                    return;
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String nazivKategorijaTereta = "nepoznato";
            String unTereta = "nepoznato";
            String nazivTereta = "nepoznato";
            String proizvodjac = "nepoznato";
            nazivKategorijaTereta = comboBoxKategorijeTereta.SelectedItem.ToString();
            SQLiteCommand nazivKategorije = sqlite.CreateCommand();
            nazivKategorije.CommandText = "select kategorijaTID from KATEGORIJA_TERETA where nazivKatTereta=" + "'" + nazivKategorijaTereta + "';";
            SQLiteDataReader dr2 = nazivKategorije.ExecuteReader();
            dr2.Read();
            unTereta = textBoxNoviTeretUN.Text;
            nazivTereta = textBoxNoviTeretNazivtereta.Text;
            proizvodjac = textBoxNoviTeretProizvodjac.Text;
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into TERET (UN, kategorijaID, naziv, proizvodjac) values ('" + unTereta + "', " + dr2.GetInt32(0) + ", '" + nazivTereta + "', '" + proizvodjac + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Teret: " + nazivTereta + " je uspešno dodat!");
            textBoxNoviTeretUN.ResetText();
            textBoxNoviTeretNazivtereta.ResetText();
            textBoxNoviTeretProizvodjac.ResetText();
            populateDropDown();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            String idtereta = "nepoznato";
            String unBr = "nepoznato";
            String kategorijaTereta = "nepoznato";
            String nazivTereta = "nepoznato";
            String proizvodjac = "nepoznato";

            if (comboBoxTeret.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    idtereta = Convert.ToString(selectedRow.Cells[0].Value);
                    unBr = Convert.ToString(selectedRow.Cells[1].Value);
                    kategorijaTereta = Convert.ToString(selectedRow.Cells[2].Value);
                    nazivTereta = Convert.ToString(selectedRow.Cells[3].Value);
                    proizvodjac = Convert.ToString(selectedRow.Cells[4].Value);

                    EditovanjeTereta editGrad = new EditovanjeTereta(this, sqlite, idtereta, unBr, kategorijaTereta, nazivTereta, proizvodjac);
                    editGrad.Show();
                }
            }
            else
            {
                SQLiteCommand nadjiTeret = sqlite.CreateCommand();
                nadjiTeret.CommandText = "select teretID, UN, kategorijaID, proizvodjac from TERET where naziv ='" + comboBoxTeret.SelectedItem.ToString() + "';";
                SQLiteDataReader dr = nadjiTeret.ExecuteReader();
                dr.Read();
                idtereta = Convert.ToString(dr.GetInt32(0));
                unBr = Convert.ToString(dr.GetInt32(1));
                int kategorijaID = dr.GetInt32(2);
                proizvodjac = dr.GetString(3);
                nazivTereta = comboBoxTeret.SelectedItem.ToString();
                SQLiteCommand nadjiIDKatT = sqlite.CreateCommand();
                nadjiIDKatT.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA where kategorijaTID =" + kategorijaID + ";";
                dr = nadjiIDKatT.ExecuteReader();
                dr.Read();
                kategorijaTereta = dr.GetString(0);

                EditovanjeTereta editGrad = new EditovanjeTereta(this, sqlite, idtereta, unBr, kategorijaTereta, nazivTereta, proizvodjac);
                editGrad.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String idtereta = "nepoznato";
            String unBr = "nepoznato";
            String kategorijaTereta = "nepoznato";
            String nazivTereta = "nepoznato";
            String proizvodjac = "nepoznato";

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            idtereta = Convert.ToString(selectedRow.Cells[0].Value);
            unBr = Convert.ToString(selectedRow.Cells[1].Value);
            kategorijaTereta = Convert.ToString(selectedRow.Cells[2].Value);
            nazivTereta = Convert.ToString(selectedRow.Cells[3].Value);
            proizvodjac = Convert.ToString(selectedRow.Cells[4].Value);

            EditovanjeTereta editGrad = new EditovanjeTereta(this, sqlite, idtereta, unBr, kategorijaTereta, nazivTereta, proizvodjac);
            editGrad.Show();
        }

      
    }
}
