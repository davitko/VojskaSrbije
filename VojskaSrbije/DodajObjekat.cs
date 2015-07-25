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
    public partial class DodajObjekat : Form
    {
        DodajTransport otac;
        DodajPrevoznika mainFormPrevoznik;
        Form1 mainForm;
        SQLiteConnection sqlite;
        int Flag = 99;
        public DodajObjekat()
        {
            InitializeComponent();
        }
        public DodajObjekat(DodajTransport form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            Flag = flag;//Ako je Flag0, znaci ubacujes novi grad za utovar, ako je flag 1 , za istovar
            populateDropDown();
        }
        public DodajObjekat(DodajPrevoznika form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.mainFormPrevoznik = form1;
            sqlite = conn;
            Flag = flag;
            populateDropDown();
        }
        public DodajObjekat(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
            populateDropDown();
        }

        public void populateDropDown()
        {
            SQLiteCommand all = sqlite.CreateCommand();
            all.CommandText = "select imeGrada, gradID from GRAD;";
            SQLiteDataReader dr = all.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajGrad dg = new DodajGrad(this,sqlite,2);
            dg.Show();
        }
        public String noviGrad
        {
            get { return noviGrad; }
            set
            {
                comboBox1.Items.Add(value);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String grad = comboBox1.Text;
            SQLiteCommand nadji = sqlite.CreateCommand();
            nadji.CommandText = "select gradID from GRAD where imeGrada='"+grad+"';";
            SQLiteDataReader dr = nadji.ExecuteReader();
            dr.Read();
            int gradID = dr.GetInt32(0);

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into OBJEKAT (imeObjekta, vojnaPosta, gradID, telefon, faks) values ('" + textBoxImeObjekta.Text + "', "+Convert.ToInt32(textBox4.Text)+", "+gradID+", '"+textBox2.Text+"','"+textBox3.Text+"');";
            add.ExecuteNonQuery();
            switch (Flag)
            {
                case 0:
                        otac.noviObjekatUtovar = textBoxImeObjekta.Text;
                        break;
                case 1:
                        otac.noviObjekatIstovar = textBoxImeObjekta.Text;
                        break;
                case 2:
                        mainFormPrevoznik.noviObjekatIme =  textBoxImeObjekta.Text;
                        mainFormPrevoznik.noviObjekatID = textBox4.Text;
                        break;
                default:
                        
                        break;
            }
           
            MessageBox.Show("Vojni Objekat: " + textBoxImeObjekta.Text + " je uspešno dodat!");
            this.Close();
        }
    }
}
