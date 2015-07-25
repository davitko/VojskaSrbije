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
    public partial class DodajTransport : Form
    {
        Form1 form1;
        SQLiteConnection sqlite;
        DataGridViewRow rowForEdit;

        // Variables for Editing
        int transportID = 0;
        String jedinica = "nepoznato";
        String nazivPosiljalac = "nepoznato";
        String vojnaPostaPosiljaoca = "nepoznato";
        int posiljaocID = 0;
        String objekatPosiljaoca = "nepoznato";
        String nazivPrimalac = "nepoznato";
        //String vojnaPostaPosiljaoca = "nepoznato";
        int primalacID = 0;
        String objekatPrimaoca = "nepoznato";
        int unBrojtereta = 0;
        String kategorijaTereta = "nepoznato";
        String nazivTereta = "nepoznato";
        String vojnaPostaPrevnozika = "nepoznato";
        DateTime vremeUtovara;
        DateTime vremeIstovara;
        int kolicinaTereta = 0;
        String mernaJedincaTereta = "nepoznato";
        String vrstaPakovanjaTereta = "nepoznato";
        int brojJedincaPakovanja = 0;
        String prevoznoSredstvo = "nepoznato";

        public IList<TERET_U_TRANSPORTU> tereti;
        public IList<int> teretIDs;


        public DodajTransport()
        {
            InitializeComponent();
            tereti = new List<TERET_U_TRANSPORTU>();
            teretIDs = new List<int>();
        }
        public DodajTransport(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            tereti = new List<TERET_U_TRANSPORTU>();
            teretIDs = new List<int>();
            populateDropDown();
            
        }
        public DodajTransport(Form1 form1, SQLiteConnection conn, DataGridViewRow row)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            rowForEdit = row;
            tereti = new List<TERET_U_TRANSPORTU>();
            teretIDs = new List<int>();
            populateFormForEdit();
            
        
        }
        private void DodajObjekat_Load(object sender, EventArgs e)
        {

        }
        public void populateFormForEdit()
        {
            try
            {
                // Get Values of Cells in passed row
                //transportID = Convert.ToInt32(rowForEdit.Cells[0].Value.ToString());
                comboBoxjedinice.SelectedText = rowForEdit.Cells[0].Value.ToString();
                comboBoxMestoUtovara.SelectedText = rowForEdit.Cells[1].Value.ToString();
                comboBoxObjekatUtovara.SelectedText = 

               // com = rowForEdit.Cells[1].Value.ToString();
                //textBoxNovaVPPosiljaoca.Text = rowForEdit.Cells[2].Value.ToString();
                
                //unBrojtereta = Convert.ToInt32(rowForEdit.Cells[3].Value.ToString());
                kategorijaTereta = rowForEdit.Cells[4].Value.ToString();
                nazivTereta = rowForEdit.Cells[5].Value.ToString();
                vojnaPostaPrevnozika = rowForEdit.Cells[6].Value.ToString();
                vremeUtovara = Convert.ToDateTime(rowForEdit.Cells[7].Value.ToString());
                vremeIstovara = Convert.ToDateTime(rowForEdit.Cells[8].Value.ToString());
                kolicinaTereta = Convert.ToInt32(rowForEdit.Cells[9].Value.ToString());
                mernaJedincaTereta = rowForEdit.Cells[10].Value.ToString();
                vrstaPakovanjaTereta = rowForEdit.Cells[11].Value.ToString();
                brojJedincaPakovanja = Convert.ToInt32(rowForEdit.Cells[12].Value.ToString());
                prevoznoSredstvo = rowForEdit.Cells[13].Value.ToString();

                // Populate Fields
                populateDropDown();

                // 1.
                //comboBoxjedinice.SelectedText = jedinica;
                SQLiteCommand findVojnaPPosiljaoca = sqlite.CreateCommand();
                findVojnaPPosiljaoca.CommandText = "select objekatID, gradID from OBJEKAT where imeObjekta = " + nazivPosiljalac + ";";
                SQLiteDataReader dataRead = findVojnaPPosiljaoca.ExecuteReader();
                int gradIDPosiljaoca = 0;
                try
                {
                    posiljaocID = dataRead.GetInt32(0);
                    //textBoxNovaVPPosiljaoca.Text = posiljaocID.ToString();
                    gradIDPosiljaoca = dataRead.GetInt32(1);
                }
                catch { }
                SQLiteCommand findVojnaPPrimaoca = sqlite.CreateCommand();
                findVojnaPPrimaoca.CommandText = "select objekatID from OBJEKAT where imeObjekta = " + nazivPrimalac + ";";
                dataRead = findVojnaPPrimaoca.ExecuteReader();
                int gradIDPrimaoca = 0;
                try
                {
                    primalacID = dataRead.GetInt32(0);
                    //textBoxNovaVPPrimaoca.Text = primalacID.ToString();
                    gradIDPrimaoca = dataRead.GetInt32(1);
                }
                catch { }
                 

            }
            catch { }
        }
        public void populateDropDown()
        {
            
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA;";
            SQLiteDataReader dr = all.ExecuteReader();
            /*while (dr.Read())
            {
                comboBoxKategorijeTereta.Items.Add(dr.GetString(0));
            }
            comboBoxKategorijeTereta.SelectedIndex = 0;*/
            dr.Close();

            all = sqlite.CreateCommand();
            all.CommandText = "select UN, naziv,teretID from TERET;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxTereti.Items.Add(dr.GetString(1));
                teretIDs.Add(dr.GetInt32(2));
            }
            comboBoxTereti.SelectedIndex = -1;
            dr.Close();
            radioButtonTeret.Checked = true;
            radioButtonNoviteret.Checked = false;
            /*textBoxNazivTereta.Enabled = false;
            textBoxUNBroj.Enabled = false;
            comboBoxKategorijeTereta.Enabled = false;
            textBoxProizvodjac.Enabled = false;*/
            
            all = sqlite.CreateCommand();
            all.CommandText = "select prevoznoSredstvo, registracioniBr, vozac from PREVOZNIK;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxPrevoznici.Items.Add(dr.GetString(0));
            }
            comboBoxPrevoznici.SelectedIndex = -1;
            dr.Close();
            radioButtonPostojeciPrevoznik.Checked = true;
            radioButtonNoviPrevoznik.Checked = false;
            textBoxPrevoznoSredstvo.Enabled = false;
            textBoxRegBr.Enabled = false;
            textBoxVozac.Enabled = false;

            all = sqlite.CreateCommand();
            all.CommandText = "select vojnaPosta, imeObjekta from OBJEKAT;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    comboBoxVPPosiljaoca.Items.Add(Convert.ToString(dr.GetInt32(0)));
                }
                catch
                {
                    comboBoxVPPosiljaoca.Items.Add(" ");
                }
                try
                {
                    comboBoxVPPrimaoca.Items.Add(Convert.ToString(dr.GetInt32(0)));
                }
                catch
                {
                    comboBoxVPPrimaoca.Items.Add(" ");
                }  
            }
            comboBoxPrevoznici.SelectedIndex = -1;
            comboBoxVPPrimaoca.SelectedIndex = -1;
            dr.Close();
            radioButtonPostojecaVojnaPostaposiljaoca.Checked = true;
            radioButtonNovaVojnaPostaPosiljaoca.Checked = false;
            //textBoxNovaVPPosiljaoca.Enabled = false;

            radioButtonPostojecaVPPrimaoca.Checked = true;
            radioButtonNovaVPPrimaoca.Checked = false;
            //textBoxNovaVPPrimaoca.Enabled = false;
            



            all.CommandText = "select imeGrada, gradID from GRAD;";
            dr = all.ExecuteReader();
            //int b = 0;
            while (dr.Read())
            {
               // comboBoxPocetakRelacije.Items.Add(dr.GetString(0));
               // comboBoxKrajRelacije.Items.Add(dr.GetString(0));
                comboBoxMestoIstovara.Items.Add(dr.GetString(0));
                comboBoxMestoUtovara.Items.Add(dr.GetString(0));
                
            }
           // comboBoxPocetakRelacije.SelectedIndex = 0;
          //  comboBoxKrajRelacije.SelectedIndex = 0;
            comboBoxMestoUtovara.SelectedIndex = 0;
            comboBoxMestoIstovara.SelectedIndex = 0;
            dr.Close();

            /*all.CommandText = "select imeObjekta from OBJEKAT;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand check = sqlite.CreateCommand();
            check.CommandText = "select count(*) from OBJEKAT where vojnaPosta="+Convert.ToInt32(comboBoxVPPosiljaoca.Text)+";";
            int broj = Convert.ToInt32(check.ExecuteScalar());
            if (broj == 0)
            {
                MessageBox.Show("Objekat sa Vojnom postom ne postoji, molim vas unesite novi objekat");
                DodajObjekat dob = new DodajObjekat(this, sqlite, 3);
                dob.Show();
                return;
            }
            check = sqlite.CreateCommand();
            check.CommandText = "select count(*) from OBJEKAT where vojnaPosta=" + Convert.ToInt32(comboBoxVPPrimaoca.Text) + ";";
             broj = Convert.ToInt32(check.ExecuteScalar());
            if (broj == 0)
            {
                MessageBox.Show("Objekat sa Vojnom postom ne postoji, molim vas unesite novi objekat");
                DodajObjekat dob = new DodajObjekat(this, sqlite, 3);
                dob.Show();
                return;
            }

            check = sqlite.CreateCommand();
            check.CommandText = "select count(*) from OBJEKAT where vojnaPosta=" + Convert.ToInt32(labelVPPrevoznika.Text) + ";";
             broj = Convert.ToInt32(check.ExecuteScalar());
            if (broj == 0)
            {
                MessageBox.Show("Objekat sa Vojnom postom ne postoji, molim vas unesite novi objekat");
                DodajObjekat dob = new DodajObjekat(this, sqlite, 3);
                dob.Show();
                return;
            }

            DateTime vremePocetka=dateTimePicker1.Value.Date;
            vremePocetka.AddHours(Convert.ToDouble(numericUpDown1.Value));
            vremePocetka.AddMinutes(Convert.ToDouble(numericUpDown2.Value));

            DateTime vremeZavrsetka = dateTimePicker2.Value.Date;
            vremeZavrsetka.AddHours(Convert.ToDouble(numericUpDown3.Value));
            vremeZavrsetka.AddMinutes(Convert.ToDouble(numericUpDown4.Value));

            String posiljalac = comboBoxObjekatUtovara.Text;
            String primalac = comboBoxObjekatIstovara.Text;

            SQLiteCommand posiljalacID = sqlite.CreateCommand();
            posiljalacID.CommandText = "select objekatID from OBJEKAT where imeObjekta='" + posiljalac + "'";
            int posiljalacId = Convert.ToInt32(posiljalacID.ExecuteScalar());

            SQLiteCommand primalacID = sqlite.CreateCommand();
            primalacID.CommandText = "select objekatID from OBJEKAT where imeObjekta='" + primalac + "'";
            int primalacId = Convert.ToInt32(primalacID.ExecuteScalar());

            /*String kategorija = labelKategorijaTereta.Text;
            SQLiteCommand kategorijaID = sqlite.CreateCommand();
            kategorijaID.CommandText = "select kategorijaTID from KATEGORIJA_TERETA where nazivKatTereta='" + kategorija + "'";
            int kategorijaId = Convert.ToInt32(kategorijaID.ExecuteScalar());

            SQLiteCommand addTeret = sqlite.CreateCommand();
            addTeret.CommandText = "insert into TERET (UN, kategorijaID, naziv,proizvodjac) values ("+labelTeretUn.Text+","+kategorijaId+",'"+comboBoxTereti.Text+"','"+labelProizvodjac.Text+"')";
            addTeret.ExecuteNonQuery();

            addTeret.CommandText = @"select last_insert_rowid()";
            int teretID = Convert.ToInt32(addTeret.ExecuteScalar());*/

            SQLiteCommand objPrev = sqlite.CreateCommand();
            objPrev.CommandText = "select objekatID from OBJEKAT where vojnaPosta=" + labelVPPrevoznika.Text + "";
            int objekatPrevoznikaID = Convert.ToInt32(objPrev.ExecuteScalar());

            SQLiteCommand addPrevoznik = sqlite.CreateCommand();
            addPrevoznik.CommandText = "insert into PREVOZNIK (prevoznoSredstvo, registracioniBr, objekatPrevoznikaID, vozac) values ('"+textBoxPrevoznoSredstvo.Text+"','"+textBoxRegBr.Text+"',"+objekatPrevoznikaID+", '"+textBoxVozac.Text+"');";
            addPrevoznik.ExecuteNonQuery();

            addPrevoznik.CommandText = @"select last_insert_rowid()";
            int prevoznikID = Convert.ToInt32(addPrevoznik.ExecuteScalar());

            String pocetak = System.Convert.ToDateTime(vremePocetka).ToString("yyyy-MM-dd HH:mm:ss");
            String zavrsetak = System.Convert.ToDateTime(vremeZavrsetka).ToString("yyyy-MM-dd HH:mm:ss");
            
            SQLiteCommand relacija = sqlite.CreateCommand();
            relacija.CommandText = "insert into RELACIJA_KRETANJA (utovarID, istovarID, vremeUtovara, vremeIstovara) values (" + posiljalacId + "," + primalacId + ", '" + pocetak + "','"+zavrsetak+"')";
            relacija.ExecuteNonQuery();
            relacija.CommandText = @"select last_insert_rowid()";
            int relacijaID = Convert.ToInt32(relacija.ExecuteScalar());


            

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into TRANSPORT ( jedinica, posiljalac, primalac, prevoznik, relacija, VPPosiljaoca, VPPrimaoca ) values ('" + comboBoxjedinice.Text + "'," + posiljalacId + "," + primalacId + "," + prevoznikID + "," + relacijaID + "," + comboBoxVPPosiljaoca.Text + "," + comboBoxVPPrimaoca.Text + ");";
            add.ExecuteNonQuery();
            add.CommandText = @"select last_insert_rowid()";
            int transportID = Convert.ToInt32(add.ExecuteScalar());
            foreach (TERET_U_TRANSPORTU t in tereti)
            {
                add.CommandText = "insert into TERET_U_TRANSPORTU (teretID,transportID,kolicina,mernaJedinica,brojJedinicaPakovanja,vrstaPakovanja) values("+t.teretID+","+transportID+","+t.kolicina+",'"+t.mernaJedinica+"',"+t.brojJedinicaPakovanja+",'"+t.vrstaPakovanja+"');";
                add.ExecuteNonQuery();
            }
            form1.populateTable();
            this.Close();
        }

        private void comboBoxMestoUtovara_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxObjekatUtovara.Items.Clear();
            comboBoxObjekatUtovara.Text = "";
            String grad = comboBoxMestoUtovara.Text;
            SQLiteCommand populate = sqlite.CreateCommand();
            populate.CommandText = "select imeObjekta from OBJEKAT where gradID in (select gradID from GRAD where imeGrada='"+grad+"');";
            SQLiteDataReader dr = populate.ExecuteReader();
            while (dr.Read())
            {
                comboBoxObjekatUtovara.Items.Add(dr.GetString(0));
            }
            try
            {
                comboBoxObjekatUtovara.SelectedIndex = 0;
            }
            catch { }
            
        }

        private void comboBoxMestoIstovara_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxObjekatIstovara.Items.Clear();
            comboBoxObjekatIstovara.Text = "";
            String grad = comboBoxMestoIstovara.Text;
            SQLiteCommand populate = sqlite.CreateCommand();
            populate.CommandText = "select imeObjekta from OBJEKAT where gradID in (select gradID from GRAD where imeGrada='" + grad + "');";
            SQLiteDataReader dr = populate.ExecuteReader();
            while (dr.Read())
            {
                comboBoxObjekatIstovara.Items.Add(dr.GetString(0));
            }
            try
            {
                comboBoxObjekatIstovara.SelectedIndex = 0;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajGrad dg = new DodajGrad(this, sqlite,0);
            dg.Show();
        }

        public String noviGradUtovar
        {
            get { return noviGradUtovar; }
            set 
        {
            comboBoxMestoUtovara.Items.Add(value);
            comboBoxMestoUtovara.SelectedIndex = comboBoxMestoUtovara.Items.Count - 1;
        } }

        public String noviGradIstovar
        {
            get { return noviGradIstovar; }
            set
            {
                comboBoxMestoIstovara.Items.Add(value);
                comboBoxMestoIstovara.SelectedIndex = comboBoxMestoIstovara.Items.Count - 1;
            }
        }
        public String noviObjekatIstovar 
        {
            get { return noviObjekatIstovar; }
            set
            {
                comboBoxObjekatIstovara.Items.Add(value);
                comboBoxObjekatIstovara.SelectedIndex = comboBoxObjekatIstovara.Items.Count - 1;
            }
        }
        public String noviObjekatUtovar
        {
            get { return noviObjekatUtovar; }
            set
            {
                comboBoxObjekatUtovara.Items.Add(value);
                comboBoxObjekatUtovara.SelectedIndex = comboBoxObjekatUtovara.Items.Count - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajGrad dg = new DodajGrad(this, sqlite, 1);
            dg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DodajObjekat dob = new DodajObjekat(this, sqlite, 1);
            dob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DodajObjekat dob = new DodajObjekat(this, sqlite, 0);
            dob.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonPostojecaVojnaPostaposiljaoca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPostojecaVojnaPostaposiljaoca.Checked)
            {
                radioButtonPostojecaVojnaPostaposiljaoca.Checked = true;
                radioButtonNovaVojnaPostaPosiljaoca.Checked = false;
                //textBoxNovaVPPosiljaoca.Enabled = false;
            }
            else
            {
                radioButtonPostojecaVojnaPostaposiljaoca.Checked = false;
                radioButtonNovaVojnaPostaPosiljaoca.Checked = true;
                //textBoxNovaVPPosiljaoca.Enabled = true;
            }
            
        }

        private void radioButtonPostojecaVPPrimaoca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPostojecaVPPrimaoca.Checked)
            {
                radioButtonPostojecaVPPrimaoca.Checked = true;
                radioButtonNovaVPPrimaoca.Checked = false;
                //textBoxNovaVPPrimaoca.Enabled = false;
            }
            else
            {
                radioButtonPostojecaVPPrimaoca.Checked = false;
                radioButtonNovaVPPrimaoca.Checked = true;
                //textBoxNovaVPPrimaoca.Enabled = true;
            }
           
        }

        private void comboBoxVPPosiljaoca_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand nadjiObjekat = sqlite.CreateCommand();
            nadjiObjekat.CommandText = "select imeObjekta, telefon from OBJEKAT where vojnaPosta= "+ Convert.ToInt32(comboBoxVPPosiljaoca.SelectedItem.ToString())+";";
            SQLiteDataReader dr = nadjiObjekat.ExecuteReader();
            dr.Read();
            try
            {
                labelPosiljalac.Text = dr.GetString(0) + dr.GetString(1);
            }
            catch
            {   }
        }

        private void comboBoxVPPrimaoca_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand nadjiObjekat = sqlite.CreateCommand();
            nadjiObjekat.CommandText = "select imeObjekta, telefon from OBJEKAT where vojnaPosta= " + Convert.ToInt32(comboBoxVPPrimaoca.SelectedItem.ToString()) + ";";
            SQLiteDataReader dr = nadjiObjekat.ExecuteReader();
            dr.Read();
            try
            {
                labelPrimalac.Text = dr.GetString(0) + dr.GetString(1);
            }
            catch
            { }
        }

        private void comboBoxTereti_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand nadjiTeretUN = sqlite.CreateCommand();
            nadjiTeretUN.CommandText = "select UN,kategorijaID,proizvodjac from TERET where naziv ='" + comboBoxTereti.SelectedItem.ToString() +"';";
            SQLiteDataReader dr = nadjiTeretUN.ExecuteReader();
            dr.Read();
            labelTeretUn.Text = Convert.ToString(dr.GetInt32(0));
            try { labelProizvodjac.Text = dr.GetString(2); }
            catch { }
            SQLiteCommand nadjiKategoriju = sqlite.CreateCommand();
            nadjiKategoriju.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA where kategorijaTID=" + dr.GetInt32(1) + ";";
            SQLiteDataReader dr2 = nadjiKategoriju.ExecuteReader();
            dr2.Read();
            String nazivkategorijeTereta = dr2.GetString(0);
            labelKategorijaTereta.Text = nazivkategorijeTereta;
            

        }

        private void comboBoxPrevoznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand nadjiRegVoz = sqlite.CreateCommand();
            nadjiRegVoz.CommandText = "select registracioniBr, vozac, objekatPrevoznikaID from PREVOZNIK where prevoznoSredstvo ='" + comboBoxPrevoznici.SelectedItem.ToString() + "';";
            SQLiteDataReader dr = nadjiRegVoz.ExecuteReader();
            dr.Read();
            try
            {
                labelRegBrPrevoznika.Text = "Registracija: " + dr.GetString(0);
            }
            catch { }
            try
            {
                labelVozac.Text = "Vozac: " + dr.GetString(1);
            }
            catch { }
            int objekatPrevoznikaID = dr.GetInt32(2);
            SQLiteCommand nadjiObj = sqlite.CreateCommand();
            nadjiObj.CommandText = "select vojnaPosta from OBJEKAT where objekatID="+objekatPrevoznikaID+";";
            SQLiteDataReader dr2 = nadjiObj.ExecuteReader();
            dr2.Read();
            try { labelVPPrevoznika.Text = dr2.GetInt32(0).ToString(); }
            catch { labelVPPrevoznika.Text = "0"; }
            
           
        }

        private void radioButtonNovaVojnaPostaPosiljaoca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNovaVojnaPostaPosiljaoca.Checked)
            {
                radioButtonPostojecaVojnaPostaposiljaoca.Checked = false;
                comboBoxVPPosiljaoca.Enabled = false;
                //textBoxNovaVPPosiljaoca.Enabled = true;
                
            }
            else
            {
                radioButtonPostojecaVojnaPostaposiljaoca.Checked = true;
                comboBoxVPPosiljaoca.Enabled = true;
                //textBoxNovaVPPosiljaoca.Enabled = false;
            }
        }

        private void radioButtonNovaVPPrimaoca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNovaVPPrimaoca.Checked)
            {
                radioButtonPostojecaVPPrimaoca.Checked = false;
                comboBoxVPPrimaoca.Enabled = false;
                //textBoxNovaVPPrimaoca.Enabled = true;
                
            }
            else
            {
                radioButtonPostojecaVPPrimaoca.Checked = true;
                comboBoxVPPrimaoca.Enabled = true;
                //textBoxNovaVPPrimaoca.Enabled = false;
            }
        }

        private void buttonDodajteret_Click(object sender, EventArgs e)
        {
            DodajTeret addteret = new DodajTeret(this, sqlite);
            addteret.Show();
        }

        private void buttonPrevoznika_Click(object sender, EventArgs e)
        {
            DodajPrevoznika addPrevoznik = new DodajPrevoznika(this, sqlite);
            addPrevoznik.Show();
        }

        private void buttonDodajteret_Click_1(object sender, EventArgs e)
        {
            DodajTeret addteret = new DodajTeret(this, sqlite);
            addteret.Show();
        }

        private void buttonDodajUListu_Click(object sender, EventArgs e)
        {
            //listViewListatereta.Items.Add()
            TERET_U_TRANSPORTU t = new TERET_U_TRANSPORTU(Convert.ToDouble(textBoxKolicinaTereta.Text), comboBoxJedinicaMereTereta.Text, Convert.ToInt32(textBoxBrojJedinicaPakovanjaTereta.Text), "");
            t.teretID = teretIDs[comboBoxTereti.SelectedIndex];
            tereti.Add(t);
            listViewListatereta.Items.Add(labelTeretUn.Text, comboBoxTereti.Text, labelKategorijaTereta.Text);
            MessageBox.Show("TERET DODAT U LISTU");
        }

        public void selectLastTeret()
        {
            comboBoxTereti.SelectedIndex = comboBoxTereti.Items.Count - 1;
        }

        

    }
}
