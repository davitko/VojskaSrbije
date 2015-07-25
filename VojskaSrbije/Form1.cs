using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SQLite;


namespace VojskaSrbije
{
    public partial class Form1 : Form
    {
        public SQLiteConnection sqlite;
        public IList<int> transportIDs;
        public Form1()
        {
            InitializeComponent();
            transportIDs = new List<int>();
            connectTobase();
            populateTable();
            dataTimePickerFormt();
            /*vScrollBar1.Dock = DockStyle.Right;
            Controls.Add(vScrollBar1);*/
        }
        public bool connectTobase()
        {
            sqlite = new SQLiteConnection("Data Source=./vojska.db");//Dodacemo posle putanju
            try
            {
                sqlite.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Konekcija sa bazom nije ostvarena");
                return false;
            }
        }

        public bool executeNonQuery(String query)
        {
            try
            {
                SQLiteCommand sql_cmd = sqlite.CreateCommand();
                sql_cmd.CommandText = query;
                sql_cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }   
        }
        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
            }
            
            return dt;
        }
        public void populateTable()
        {
            dataGridView1.Rows.Clear();
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select * from TRANSPORT;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                // 1.Jedinica
                String jedinica = dr.GetString(1);
                
                // 3. Objekat Posiljaoca
                SQLiteCommand posiljalac = sqlite.CreateCommand();
                posiljalac.CommandText = "select imeObjekta, vojnaPosta, gradID from OBJEKAT where objekatID=" + dr.GetInt32(2) + ";";
                SQLiteDataReader dr2 = posiljalac.ExecuteReader();
                dr2.Read();
                String imePosiljaoca = "nepoznato";
                try
                {
                    imePosiljaoca = dr2.GetString(0);
                }
                catch {  }
                
                // 2.Vojna Posta Posiljaoca
                String vojnaPostaPosiljaoca = "nepoznato";
                try
                { 
                    vojnaPostaPosiljaoca = dr2.GetString(1);
                }
                catch { }
                
                // 4. Grad Posiljaoca
                int gradIDPosiljaoca = dr2.GetInt32(2);
                SQLiteCommand nadjiGradPosiljalac = sqlite.CreateCommand();
                nadjiGradPosiljalac.CommandText = "select imeGrada from GRAD where gradID=" + gradIDPosiljaoca + ";";
                dr2 = nadjiGradPosiljalac.ExecuteReader();
                dr2.Read();
                String gradPosiljaoca = "nepoznat";
                try
                {
                    gradPosiljaoca = dr2.GetString(0);
                }
                catch
                {
                    MessageBox.Show("Ne mozemo da nadjemo grad Posiljaoca");
                }
                
                // 5. Objekat Utovara
                SQLiteCommand nadjiIDObjektaUtovaraIstovara = sqlite.CreateCommand();
                nadjiIDObjektaUtovaraIstovara.CommandText = "select utovarID, istovarID from RELACIJA_KRETANJA where relacijaID=" + dr.GetInt32(6) + ";";
                dr2 = nadjiIDObjektaUtovaraIstovara.ExecuteReader();
                dr2.Read();
                int utovarIDObj = -1;
                try
                {
                    utovarIDObj = dr2.GetInt32(0);
                }
                catch {
                    MessageBox.Show("Ne postoji Relacija za Transport: " + Convert.ToString(dr.GetInt32(0)) + " pa ce bii dodeljena default-na vrednost!");
                }
                int istovarIDObj = dr2.GetInt32(1);
                SQLiteCommand nadjiImeObjektaUtovara = sqlite.CreateCommand();
                nadjiImeObjektaUtovara.CommandText = "select imeObjekta, gradID from OBJEKAT where objekatID=" + utovarIDObj + ";";
                dr2 = nadjiImeObjektaUtovara.ExecuteReader();
                dr2.Read();
                String objekatUtovara = dr2.GetString(0);
                int gradIDUtovara = dr2.GetInt32(1);

                // 10. Objekat Istovara
                SQLiteCommand nadjiImeObjektaIstovara = sqlite.CreateCommand();
                nadjiImeObjektaIstovara.CommandText = "select imeObjekta, gradID from OBJEKAT where objekatID=" + istovarIDObj + ";";
                dr2 = nadjiImeObjektaIstovara.ExecuteReader();
                dr2.Read();
                String objekatIstovara = dr2.GetString(0);
                int gradIDIstovara = dr2.GetInt32(1);

                // 6. Grad Utovara
                SQLiteCommand nadjiImeGradaUtovara = sqlite.CreateCommand();
                nadjiImeGradaUtovara.CommandText = "select imeGrada from GRAD where gradID=" + gradIDUtovara + ";";
                dr2 = nadjiImeGradaUtovara.ExecuteReader();
                dr2.Read();
                String gradUtovara = dr2.GetString(0);

                // 11. Grad Istovara
                SQLiteCommand nadjiImeGradaIstovara = sqlite.CreateCommand();
                nadjiImeGradaIstovara.CommandText = "select imeGrada from GRAD where gradID=" + gradIDIstovara + ";";
                dr2 = nadjiImeGradaIstovara.ExecuteReader();
                dr2.Read();
                String gradIstovara = dr2.GetString(0);

                // 8. Primalac
                SQLiteCommand primalac = sqlite.CreateCommand();
                primalac.CommandText = "select imeObjekta, vojnaPosta, gradID from OBJEKAT where objekatID=" + dr.GetInt32(3) + ";";
                dr2 = primalac.ExecuteReader();
                dr2.Read();
                String imePrimaoca = dr2.GetString(0);

                // 7. Vojna Posta Primaoca
                String vojnaPostaPrimaoca = "nepoznato";
                try
                {
                    vojnaPostaPrimaoca = dr2.GetString(1);
                }
                catch { }

                // 9. GradPrimaoca
                int gradIDPrimaoca = dr2.GetInt32(2);
                SQLiteCommand nadjiGradPrimalac = sqlite.CreateCommand();
                nadjiGradPrimalac.CommandText = "select imeGrada from GRAD where gradID=" + gradIDPrimaoca + ";";
                dr2 = nadjiGradPrimalac.ExecuteReader();
                dr2.Read();
                String gradPrimaoca = dr2.GetString(0);


                // 15.Vojna Posta Prevoznika
                SQLiteCommand prevoznik = sqlite.CreateCommand();
                prevoznik.CommandText = "select objekatPrevoznikaID, prevoznoSredstvo from PREVOZNIK where prevoznikID=" + dr.GetInt32(5) + ";";
                dr2 = prevoznik.ExecuteReader();
                dr2.Read();
                int objekatPrevoznikaID = 1;
                try
                {
                    objekatPrevoznikaID = dr2.GetInt32(0);
                }
                catch {
                    MessageBox.Show("Niste naveli objekat Prevoznika! Bice stavljan default Objekat", "Paznja!");
                    objekatPrevoznikaID = 1;
                }
                // 22. Prevozno Sredstvo
                String prevoznoSredstvo = dr2.GetString(1);

                // 15... 
                SQLiteCommand vojnaPosta = sqlite.CreateCommand();
                vojnaPosta.CommandText = "select vojnaPosta from OBJEKAT where objekatID=" + objekatPrevoznikaID + ";";
                SQLiteDataReader dr3 = vojnaPosta.ExecuteReader();
                dr3.Read();
                String VojnaPostaPrevoznika ="nema";
                try {
                    VojnaPostaPrevoznika = dr3.GetInt32(0).ToString();
                }
                catch { }

                

                // 11.
                SQLiteCommand relacija = sqlite.CreateCommand();
                relacija.CommandText = "select vremeUtovara,vremeIstovara from RELACIJA_KRETANJA where relacijaID=" + dr.GetInt32(6) + ";";
                dr2 = relacija.ExecuteReader();
                dr2.Read();
                String vremeUtovara = "nepoznato";
                String vremeIstovara = "nepoznato";
                try
                {
                     vremeUtovara = dr2.GetDateTime(0).ToString();  
                }
                catch { }
                try
                {
                    vremeIstovara = dr2.GetDateTime(1).ToString();
                }
                catch {  }
                

                //                         jedinica,   imePosiljaoca, imePrimaoca, UN, kategorijaT, nazivT, VojnaPostaPrevoznika,   
                dataGridView1.Rows.Add(jedinica, vojnaPostaPosiljaoca, imePosiljaoca, gradPosiljaoca, objekatUtovara, gradUtovara, vojnaPostaPrimaoca, imePrimaoca, gradPrimaoca, objekatIstovara, gradIstovara, VojnaPostaPrevoznika, vremeUtovara, vremeIstovara, prevoznoSredstvo);
                transportIDs.Add(dr.GetInt32(0));
                dr2.Close();
                dr3.Close();
            }
            dr.Close();

            comboBoxPocetakRelacije.Items.Add("-bilo koji-");
            comboBoxKrajRelacije.Items.Add("-bilo koji-");
            comboBoxNazivTereta.Items.Add("-bilo koji-");
            comboBoxPrevoznoSredstvo.Items.Add("-bilo koji-");
            comboBoxUNtereta.Items.Add("-bilo koji-");
            comboBoxVPPrevoznika.Items.Add("-bilo koji-");
            comboBoxKategorijaTereta.Items.Add("-bilo koji-");
            all.CommandText = "select imeGrada, gradID from GRAD;";
            dr = all.ExecuteReader();
            int b = 0;
            while (dr.Read())
            {
                comboBoxPocetakRelacije.Items.Add(dr.GetString(0));
                comboBoxKrajRelacije.Items.Add(dr.GetString(0));
            }
            dr.Close();

            all.CommandText = "select naziv, UN, kategorijaID from TERET;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxNazivTereta.Items.Add(dr.GetString(0));
                comboBoxUNtereta.Items.Add(dr.GetInt32(1));
              
            }
            dr.Close();

              SQLiteCommand kat = sqlite.CreateCommand();
                kat.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA";
                dr = kat.ExecuteReader();
                while(dr.Read())
                    comboBoxKategorijaTereta.Items.Add(dr.GetString(0));
                dr.Close();

            all.CommandText = "select prevoznoSredstvo, objekatPrevoznikaID from PREVOZNIK;";
            dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBoxPrevoznoSredstvo.Items.Add(dr.GetString(0));
                SQLiteCommand vp = sqlite.CreateCommand();
                vp.CommandText = "select vojnaPosta from OBJEKAT where objekatID="+dr.GetInt32(1)+";";
                try { comboBoxVPPrevoznika.Items.Add(Convert.ToInt32(vp.ExecuteScalar())); }
                catch { }
                
            }
            dr.Close();

            



        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*DateTime danas = DateTime.Now;
            int mesec=danas.Month;*/
            sqlite.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajTransport dobjekat=new DodajTransport(this,sqlite);
            dobjekat.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxjedinice_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void comboBoxPocetakRelacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxKrajRelacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
        public void visibleAll()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
            }
        }

        public void search()
        {
            visibleAll();
            int mesec = comboBox1.SelectedIndex;
            String jedinica = comboBoxjedinice.Text;
            double kolicina=0.0;
            try
            {
                 kolicina = Convert.ToDouble(textBox1.Text);
            }
            catch { }
            String naziv = comboBoxNazivTereta.Text;
            int UN = 0;
            try
            {
                UN = Convert.ToInt32(comboBoxUNtereta.Text);
            }
            catch { }
            String vojnaPosta = comboBoxVPPrevoznika.Text;
            String sredstvo = comboBoxPrevoznoSredstvo.Text;
            String od = comboBoxPocetakRelacije.Text;
            String dogde = comboBoxKrajRelacije.Text;
            String kategorijaTereta = comboBoxKategorijaTereta.Text;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (mesec != 0)
                {
                    try
                    {
                        if (!comboBox1.Text.Equals(""))
                            if (Convert.ToDateTime(r.Cells[12].Value).Month != mesec)
                            {
                                r.Visible = false;
                            }
                    }
                    catch { }
                    
                }
                if (!jedinica.Equals("-Sve jedinice-") )
                {
                    if(!comboBoxjedinice.Text.Equals(""))
                        if (!Convert.ToString(r.Cells[0].Value).Equals(jedinica))
                        {
                            r.Visible = false;
                        }
                }
                if (kolicina != 0.0)
                {
                    int transportID=transportIDs[r.Index];
                    SQLiteCommand kol = sqlite.CreateCommand();
                    kol.CommandText = "select kolicina from TERET_U_TRANSPORTU where transportID="+transportID+"";
                    SQLiteDataReader dr = kol.ExecuteReader();
                    int tmp = 0;
                    while (dr.Read())
                    {
                        if (dr.GetDouble(0) < kolicina)
                        {
                            tmp++;
                        }
                    }
                    if (tmp == 0)
                    {
                        r.Visible = false;
                    }
                    /*if (Convert.ToDouble(r.Cells[9].Value) > kolicina)
                    {
                        r.Visible = false;
                    }*/
                }
                if (!naziv.Equals("-bilo koji-"))
                {
                    if (!naziv.Equals(""))
                    {
                        int transportID = transportIDs[r.Index];
                        SQLiteCommand kol = sqlite.CreateCommand();
                        kol.CommandText = "select teretID from TERET_U_TRANSPORTU where transportID=" + transportID + "";
                        SQLiteDataReader dr = kol.ExecuteReader();
                        int tmp = 0;
                        while (dr.Read())
                        {
                            SQLiteCommand naz = sqlite.CreateCommand();
                            naz.CommandText = "select naziv from TERET where teretID=" + dr.GetInt32(0) + "";
                            SQLiteDataReader dr2 = naz.ExecuteReader();
                            dr2.Read();
                            if (dr2.GetString(0).Equals(naziv))
                            { tmp++; }

                        }
                        if (tmp == 0)
                        {
                            r.Visible = false;
                        }
                        /*
                        if (!Convert.ToString(r.Cells[5].Value).Contains(naziv))
                        {
                            r.Visible = false;
                        }*/
                    }
                }
                if (!UN.Equals("-bilo koji-"))
                {
                    if (UN != 0)
                    {

                        int transportID = transportIDs[r.Index];
                        SQLiteCommand kol = sqlite.CreateCommand();
                        kol.CommandText = "select teretID from TERET_U_TRANSPORTU where transportID=" + transportID + "";
                        SQLiteDataReader dr = kol.ExecuteReader();
                        int tmp = 0;
                        while (dr.Read())
                        {
                            SQLiteCommand uun = sqlite.CreateCommand();
                            uun.CommandText = "select UN from TERET where teretID=" + dr.GetInt32(0) + "";
                            SQLiteDataReader dr2 = uun.ExecuteReader();
                            dr2.Read();
                            if (dr2.GetInt32(0).Equals(UN))
                            { tmp++; }
                        }
                        if (tmp == 0)
                        {
                            r.Visible = false;
                        }
                        /*
                        if (Convert.ToInt32(r.Cells[3].Value) != UN)
                        {
                            r.Visible = false;
                        }*/
                    }
                }
                if (!vojnaPosta.Equals("-bilo koji-"))
                {
                    if (!vojnaPosta.Equals(""))
                    {

                        if (!Convert.ToString(r.Cells[11].Value).Contains(vojnaPosta))
                        {
                            r.Visible = false;
                        }
                    }
                }

                if (!kategorijaTereta.Equals("-bilo koji-"))
                {
                    if (!kategorijaTereta.Equals(""))
                    {

                        int transportID = transportIDs[r.Index];
                        SQLiteCommand kol = sqlite.CreateCommand();
                        kol.CommandText = "select teretID from TERET_U_TRANSPORTU where transportID=" + transportID + "";
                        SQLiteDataReader dr = kol.ExecuteReader();
                        int tmp = 0;
                        while (dr.Read())
                        {
                            SQLiteCommand uun = sqlite.CreateCommand();
                            uun.CommandText = "select kategorijaID from TERET where teretID=" + dr.GetInt32(0) + "";
                            SQLiteDataReader dr2 = uun.ExecuteReader();
                            while (dr2.Read())
                            {
                                SQLiteCommand kat = sqlite.CreateCommand();
                                kat.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA where kategorijaTID="+dr2.GetInt32(0)+"";
                                SQLiteDataReader dr3 = kat.ExecuteReader();
                                while (dr3.Read())
                                    if (dr3.GetString(0).Equals(kategorijaTereta))
                                        { tmp++; }
                            }
                            
                        }
                        if (tmp == 0)
                        {
                            r.Visible = false;
                        }
                    }
                }

                if (!sredstvo.Equals("-bilo koji-"))
                {

                    if (!sredstvo.Equals(""))
                    {
                        if (!Convert.ToString(r.Cells[14].Value).Contains(sredstvo))
                        {
                            r.Visible = false;
                        }
                    }
                }
                if (!od.Equals("-bilo koji-"))
                {
                    if(!comboBoxPocetakRelacije.Text.Equals(""))
                    {
                         SQLiteCommand all2 = sqlite.CreateCommand();
                        all2.CommandText = "select gradID from GRAD where imeGrada ='"+ od + "';";
                        int gradID2 = Convert.ToInt32(all2.ExecuteScalar());
                        String imeObjekta = Convert.ToString(r.Cells[2].Value);
                        SQLiteCommand all = sqlite.CreateCommand();
                        all.CommandText = "select gradID from OBJEKAT where imeObjekta='" + imeObjekta + "';";
                        int gradID = Convert.ToInt32(all.ExecuteScalar());

                        if (!gradID.Equals(gradID2))
                        {
                            r.Visible = false;
                        }
                    }
                   
                }
                if (!dogde.Equals("-bilo koji-") )
                {
                    if(!comboBoxKrajRelacije.Text.Equals(""))
                    {
                        SQLiteCommand all2 = sqlite.CreateCommand();
                    all2.CommandText = "select gradID from GRAD where imeGrada='" + dogde + "';";
                    int gradID2 = Convert.ToInt32(all2.ExecuteScalar());
                    String imeObjekta = Convert.ToString(r.Cells[7].Value);
                    SQLiteCommand all = sqlite.CreateCommand();
                    all.CommandText = "select gradID from OBJEKAT where imeObjekta='" + imeObjekta + "';";
                    int gradID = Convert.ToInt32(all.ExecuteScalar());

                    if (!gradID.Equals(gradID2))
                    {
                        r.Visible = false;
                    }
                    }
                    
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTereti.Rows.Clear();
            SQLiteCommand teret = sqlite.CreateCommand();
            teret.CommandText = "select teretTransportID, teretID,kolicina, mernaJedinica, brojJedinicaPakovanja, vrstaPakovanja from TERET_U_TRANSPORTU where transportID="+transportIDs[e.RowIndex]+"";
            SQLiteDataReader dr = teret.ExecuteReader();

            while (dr.Read())
            {
                SQLiteCommand naziv = sqlite.CreateCommand();
                naziv.CommandText = "select UN, kategorijaID,naziv,proizvodjac from TERET where teretID="+dr.GetInt32(1)+";";
                SQLiteDataReader dr2 = naziv.ExecuteReader();
                dr2.Read();
                String proizvodjac;
                try { proizvodjac = dr2.GetString(3); }
                catch
                {
                    proizvodjac = "nema";
                }
                SQLiteCommand kategorija = sqlite.CreateCommand();
                kategorija.CommandText = "select nazivKatTereta from KATEGORIJA_TERETA where kategorijaTID="+dr2.GetInt32(1)+";";
                SQLiteDataReader dr3 = kategorija.ExecuteReader();
                dr3.Read();
                String nazivKategorije = dr3.GetString(0);
                dataGridViewTereti.Rows.Add(dr2.GetInt32(0), nazivKategorije, dr2.GetString(2), proizvodjac,dr.GetDouble(2),dr.GetString(3),dr.GetInt32(4),dr.GetString(5));
            }

            /*DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            DodajTransport editTransport = new DodajTransport(this, sqlite, row);
            editTransport.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajGrad newGrad = new DodajGrad(this, sqlite);
            newGrad.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajObjekat newObj = new DodajObjekat(this, sqlite);
            newObj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DodajKategorijutereta newKategorija = new DodajKategorijutereta(this, sqlite);
            newKategorija.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DodajPrevoznika newPrevoznik = new DodajPrevoznika(this, sqlite);
            newPrevoznik.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DodajTeret newTeret = new DodajTeret(this, sqlite);
            newTeret.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DodajRelaciju newRelacija = new DodajRelaciju(this, sqlite);
            newRelacija.Show();
        }
        public void dataTimePickerFormt()
        {
            dateTimePickerVremeUtovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeUtovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeUtovara.ShowUpDown = true;

            dateTimePickerVremeIstovara.CustomFormat = "dd.MM.yyyy hh:mm tt";
            dateTimePickerVremeIstovara.Format = DateTimePickerFormat.Custom;
            dateTimePickerVremeIstovara.ShowUpDown = true;
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajTransport dobjekat = new DodajTransport(this, sqlite);
            dobjekat.Show();
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajGrad newGrad = new DodajGrad(this, sqlite);
            newGrad.Show();
        }

        private void objekatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajObjekat newObj = new DodajObjekat(this, sqlite);
            newObj.Show();
        }

        private void kategorijaTeretaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKategorijutereta newKategorija = new DodajKategorijutereta(this, sqlite);
            newKategorija.Show();
        }

        private void teretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajTeret newTeret = new DodajTeret(this, sqlite);
            newTeret.Show();
        }

        private void prevoznikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajPrevoznika newPrevoznik = new DodajPrevoznika(this, sqlite);
            newPrevoznik.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VidiObjekat viewObj = new VidiObjekat(this, sqlite);
            viewObj.Show();
        }

        private void gradToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VidiGrad viewGrad = new VidiGrad(this, sqlite);
            viewGrad.Show();
        }

        private void kategorijaTeretaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VidiKategorijuTereta viewKatT = new VidiKategorijuTereta(this, sqlite);
            viewKatT.Show();
        }

        private void teretToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VidiTeret viewTeret = new VidiTeret(this, sqlite);
            viewTeret.Show();
        }

        private void prevoznikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VidiPrevonika viewPrevoznik = new VidiPrevonika(this, sqlite);
            viewPrevoznik.Show();
        }

        private void relacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VidiRelaciju viewRelacija = new VidiRelaciju(this, sqlite);
            viewRelacija.Show();
        }

        private void comboBoxNazivTereta_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxKategorijaTereta_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxUNtereta_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxPrevoznoSredstvo_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void comboBoxVPPrevoznika_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void exportToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true); 
        }

    }
}
