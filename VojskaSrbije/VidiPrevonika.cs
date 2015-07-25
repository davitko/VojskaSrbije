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
using System.Data.SQLite;

namespace VojskaSrbije
{
    public partial class VidiPrevonika : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;

        public VidiPrevonika()
        {
            InitializeComponent();
        }
        public VidiPrevonika(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn; 
            populateDropDown();
        }
        public void populateDropDown()
        {
            int objekatPrevoznikaID = -1;
            String nazivbjektaPrevoznika = "nepoznato";
            dataGridView1.Rows.Clear();
            comboBoxObjekti.Items.Clear();
            comboBoxPrevoznici.Items.Clear();

            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select prevoznikID, prevoznoSredstvo, registracioniBr, objekatPrevoznikaID, vozac from PREVOZNIK;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxPrevoznici.Items.Add(dr.GetString(2));
                objekatPrevoznikaID = dr.GetInt32(3);
                SQLiteCommand nazivObjekta = sqlite.CreateCommand();
                nazivObjekta.CommandText = "select imeObjekta from OBJEKAT where objekatID=" + objekatPrevoznikaID + ";";
                SQLiteDataReader dr2 = nazivObjekta.ExecuteReader();
                dr2.Read();
                nazivbjektaPrevoznika = dr2.GetString(0);
                comboBoxObjekti.Items.Add(nazivbjektaPrevoznika);
                dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), nazivbjektaPrevoznika, dr.GetString(4));
            }
            comboBoxPrevoznici.SelectedIndex = -1;
            comboBoxObjekti.SelectedIndex = -1;
            dr.Close();
        }
        private void deleteItem(String deletedGrad)
        {
            String prevoznoSredstvo = "nepoznato";

            SQLiteCommand nazivPrevoznogSredstva = sqlite.CreateCommand();
            nazivPrevoznogSredstva.CommandText = "select prevoznoSredstvo from PREVOZNIK where registracioniBr = '" + deletedGrad + "';";
            SQLiteDataReader dr = nazivPrevoznogSredstva.ExecuteReader();
            dr.Read();
            prevoznoSredstvo = dr.GetString(0);

            SQLiteCommand deleteGrad = sqlite.CreateCommand();
            deleteGrad.CommandText = "DELETE FROM PREVOZNIK WHERE registracioniBr ='" + deletedGrad + "';";
            try
            {
                deleteGrad.ExecuteNonQuery();

                MessageBox.Show("Uspesno je obrisan prevoznik sa prevoznim sredstvom: " + prevoznoSredstvo + " sa registracijom: " + deletedGrad);
                populateDropDown();
            }
            catch
            {
                MessageBox.Show("Doslo je do greske prilikom brisanja Prevoznika sa prevoznim sredstvom: " + prevoznoSredstvo + " sa registracijom: " + deletedGrad, "Paznja!");
            }
            
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            String deleted = "nepoznato";
            if (comboBoxPrevoznici.SelectedIndex == -1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    deleted = Convert.ToString(selectedRow.Cells[2].Value);

                    DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete prevoznika sa registracijom: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

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
                deleted = comboBoxPrevoznici.SelectedItem.ToString();
                DialogResult dr = MessageBox.Show("Da li stvarno zelite da obrisete prevoznika sa registracijom: " + deleted + " iz liste?", "Upozorenje!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

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
                    comboBoxPrevoznici.SelectedIndex = -1;
                    return;
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            int objekatID = -1;
            String imePrevoznogSredstva = "nepoznato";
            String imeObjektaPrvoznika = "nepoznato";
            String regBr = "nepoznato";
            String vozac = "nepoznato";

            imePrevoznogSredstva = textBoxPrevoznoSredstvo.Text;
            imeObjektaPrvoznika = comboBoxObjekti.SelectedItem.ToString();
            regBr = textBoxRegistracioniBroj.Text;
            vozac = textBoxVozac.Text;
           
            SQLiteCommand nadjiIDObjekta = sqlite.CreateCommand();
            nadjiIDObjekta.CommandText = "select objekatID from OBJEKAT where imeObjekta=" + "'" + imeObjektaPrvoznika + "';";
            SQLiteDataReader dr2 = nadjiIDObjekta.ExecuteReader();
            dr2.Read();
            objekatID = dr2.GetInt32(0);

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into PREVOZNIK (prevoznoSredstvo, registracioniBr, vozac, objekatPrevoznikaID) values ('" + imePrevoznogSredstva + "', '" + regBr + "', '" + vozac + "', " + objekatID + ");";
            add.ExecuteNonQuery();
            MessageBox.Show("Prevoznik sa prevoznim sredstvom: " + imePrevoznogSredstva + " sa registacionim brojem: " + regBr  + " je uspešno dodat!");
            textBoxPrevoznoSredstvo.ResetText();
            textBoxRegistracioniBroj.ResetText();
            textBoxVozac.ResetText();
            populateDropDown();
        }

        
    }
}
