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
    public partial class VidiKategorijuTereta : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;
        public VidiKategorijuTereta()
        {
            InitializeComponent();
        }
        public VidiKategorijuTereta(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }
        public void populateDropDown()
        {
            dataGridView1.Rows.Clear();
            comboBoxKategorije.Items.Clear();
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select kategorijaTID, nazivKatTereta from KATEGORIJA_TERETA;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxKategorije.Items.Add(dr.GetString(1));
                dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1));
            }
            comboBoxKategorije.SelectedIndex = -1;
            dr.Close();
        }
        private void deleteItem(String deletedKatTereta)
        {
            SQLiteCommand deleteGrad = sqlite.CreateCommand();
            deleteGrad.CommandText = "DELETE FROM KATEGORIJA_TERETA WHERE nazivKatTereta ='" + deletedKatTereta + "';";
            deleteGrad.ExecuteNonQuery();
            //comboBoxKategorije.Items.Remove(comboBoxKategorije.SelectedItem);
            MessageBox.Show("Uspesno je obrisana Kategorija Tereta: " + deletedKatTereta);
            populateDropDown();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            String deletedKatTereta = "nepoznato";
            if (comboBoxKategorije.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    deletedKatTereta = Convert.ToString(selectedRow.Cells[1].Value);

                    DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete kategoriju tereta: " + deletedKatTereta + "iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        deleteItem(deletedKatTereta);
                        return;

                    }
                    else if (dr == DialogResult.No)
                    {
                        comboBoxKategorije.SelectedIndex = -1;
                        return;
                    }

                }
            }
            else
            {
                deletedKatTereta = comboBoxKategorije.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete grad: " + deletedKatTereta  + "iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    deletedKatTereta = comboBoxKategorije.SelectedItem.ToString();
                    deleteItem(deletedKatTereta);
                    return;

                }
                else if (dr == DialogResult.No)
                {
                    comboBoxKategorije.SelectedIndex = -1;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into KATEGORIJA_TERETA (nazivKatTereta) values ('" + textBoxNovaKategorija.Text + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Grad: " + textBoxNovaKategorija.Text + " je uspešno dodat!");
            textBoxNovaKategorija.ResetText();
            populateDropDown();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int idKat = -1;
            String imeKat = "nepoznato";

              if (comboBoxKategorije.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    String idKatT = Convert.ToString(selectedRow.Cells[0].Value);
                    imeKat = Convert.ToString(selectedRow.Cells[1].Value);
                    idKat = Convert.ToInt32(idKatT);

                    EditKategorijeTereta editGrad = new EditKategorijeTereta(this, sqlite, idKat, imeKat);
                    editGrad.Show();
                }
            }
            else
            {
                SQLiteCommand nadjiIObj = sqlite.CreateCommand();
                nadjiIObj.CommandText = "select kategorijaTID  from KATEGORIJA_TERETA where nazivKatTereta ='" + comboBoxKategorije.SelectedItem.ToString() + "';";
                SQLiteDataReader dr = nadjiIObj.ExecuteReader();
                dr.Read();
                idKat = dr.GetInt32(0);
                imeKat = comboBoxKategorije.SelectedItem.ToString();

                EditKategorijeTereta editGrad = new EditKategorijeTereta(this, sqlite, idKat, imeKat);
                editGrad.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idKat = -1;
            String imeKat = "nepoznato";
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            String idKatT = Convert.ToString(selectedRow.Cells[0].Value);
            imeKat = Convert.ToString(selectedRow.Cells[1].Value);
            idKat = Convert.ToInt32(idKatT);

            EditKategorijeTereta editGrad = new EditKategorijeTereta(this, sqlite, idKat, imeKat);
            editGrad.Show();
        }
    }
}
