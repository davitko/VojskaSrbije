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
    public partial class VidiGrad : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;
        //DataGridViewRow rowForEdit;

        public VidiGrad()
        {
            InitializeComponent();
        }
        public VidiGrad(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into GRAD (imeGrada) values ('" + textBoxNoviGrad.Text + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Grad: " + textBoxNoviGrad.Text + " je uspešno dodat!");
            textBoxNoviGrad.ResetText();
            populateDropDown();
            //this.noviGrad = textBoxNoviGrad.Text;

            //DodajGrad newGrad = new DodajGrad(this, sqlite, 2);
            //newGrad.Show();
        }
        public String noviGrad
        {
            get { return noviGrad; }
            set
            {
                comboBoxGradovi.Items.Add(value);
                comboBoxGradovi.SelectedIndex = comboBoxGradovi.Items.Count - 1;
            }
        }
        public void populateDropDown()
        {
            dataGridView1.Rows.Clear();
            comboBoxGradovi.Items.Clear();
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select imeGrada, gradID from GRAD;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxGradovi.Items.Add(dr.GetString(0));
                dataGridView1.Rows.Add(dr.GetInt32(1), dr.GetString(0));
            }
            comboBoxGradovi.SelectedIndex = -1;
            dr.Close();
        }

        private void deleteItem (String deletedGrad)
        {
            SQLiteCommand deleteGrad = sqlite.CreateCommand();
            deleteGrad.CommandText = "DELETE FROM GRAD WHERE imeGrada ='" + deletedGrad + "';";
            deleteGrad.ExecuteNonQuery();
            //comboBoxGradovi.Items.Remove(comboBoxGradovi.SelectedItem);
            MessageBox.Show("Uspesno je obrisan grad: " + deletedGrad);
            populateDropDown();
        }
        private void buttonObrisi_Click(object sender, EventArgs e)
        {
           // MessageBoxButtons 
           // MessageBoxButtons dugmeOkC[] = new MessageBoxButtons();
            String deletedGrad = "nepoznato";
            if (comboBoxGradovi.SelectedIndex == -1)
            {
               if (dataGridView1.SelectedCells.Count > 0)
             {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                deletedGrad = Convert.ToString(selectedRow.Cells[1].Value);

                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete grad: " + deletedGrad + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    deleteItem(deletedGrad);
                    return;

                }
                else if (dr == DialogResult.No)
                {
                    comboBoxGradovi.SelectedIndex = -1;
                    return;
                }

              }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete grad: " + comboBoxGradovi.SelectedText + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    deletedGrad = comboBoxGradovi.SelectedItem.ToString();
                    deleteItem(deletedGrad);
                    return;

                }
                else if (dr == DialogResult.No)
                {
                    comboBoxGradovi.SelectedIndex = -1;
                    return;
                }
            }

          
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String idGrada = "nepoznato";
            String imeGrada = "nepoznato";
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            idGrada = Convert.ToString(selectedRow.Cells[0].Value);
            imeGrada = Convert.ToString(selectedRow.Cells[1].Value);

            EditGrad editGrad = new EditGrad(this, sqlite, idGrada, imeGrada);
            editGrad.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            String idGrada = "nepoznato";
            String imeGrada = "nepoznato";
            if (comboBoxGradovi.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    idGrada = Convert.ToString(selectedRow.Cells[0].Value);
                    imeGrada = Convert.ToString(selectedRow.Cells[1].Value);

                    EditGrad editGrad = new EditGrad(this, sqlite, idGrada, imeGrada);
                    editGrad.Show();
                }
            }
            else
            {
                SQLiteCommand nadjiIdGrada = sqlite.CreateCommand();
                nadjiIdGrada.CommandText = "select gradID from GRAD where imeGrada ='" + comboBoxGradovi.SelectedItem.ToString() + "';";
                SQLiteDataReader dr = nadjiIdGrada.ExecuteReader();
                dr.Read();
                //int broj = dr.GetInt32(0);
                idGrada = Convert.ToString(dr.GetInt32(0));
                imeGrada = comboBoxGradovi.SelectedItem.ToString();

                EditGrad editGrad = new EditGrad(this, sqlite, idGrada, imeGrada);
                editGrad.Show();
                populateDropDown();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String idGrada = "nepoznato";
            String imeGrada = "nepoznato";
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            idGrada = Convert.ToString(selectedRow.Cells[0].Value);
            imeGrada = Convert.ToString(selectedRow.Cells[1].Value);

            EditGrad editGrad = new EditGrad(this, sqlite, idGrada, imeGrada);
            editGrad.Show();
            populateDropDown();
        }

        private void VidiGrad_Enter(object sender, EventArgs e)
        {
            populateDropDown();
        }

        private void VidiGrad_Load(object sender, EventArgs e)
        {
            populateDropDown();
        }
    }
}
