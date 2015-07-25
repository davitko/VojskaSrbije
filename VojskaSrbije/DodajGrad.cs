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
    public partial class DodajGrad : Form
    {
        DodajTransport otac;
        Form1 mainForm;
        DodajObjekat objekat;
        VidiGrad mainFormVidiGrad;
        SQLiteConnection sqlite;
        int Flag = 99;
        public DodajGrad()
        {
            InitializeComponent();
        }
        public DodajGrad(DodajTransport form1, SQLiteConnection conn,int flag)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
            Flag = flag;//Ako je Flag0, znaci ubacujes novi grad za utovar, ako je flag 1 , za istovar
        }
        public DodajGrad(DodajObjekat form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.objekat = form1;
            sqlite = conn;
        }
        public DodajGrad(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
        }
        public DodajGrad(VidiGrad form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.mainFormVidiGrad = form1;
            sqlite = conn;
            Flag = flag;
        }

        public void addCity()
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Molimo Vas unesite ime grada .");
                return;
            }

            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into GRAD (imeGrada) values ('" + textBox1.Text + "');";
            add.ExecuteNonQuery();
            switch (Flag)
            {
                case 0:
                    otac.noviGradUtovar = textBox1.Text;
                    break;
                case 1:
                    otac.noviGradIstovar = textBox1.Text;
                    break;
                case 2:
                    mainFormVidiGrad.noviGrad = textBox1.Text;
                    break;
                default:
                    objekat.noviGrad = textBox1.Text;
                    break;
            }
            if (Flag == 0)
                otac.noviGradUtovar = textBox1.Text;
            else
                if (Flag == 1)
                    otac.noviGradIstovar = textBox1.Text;
                else
                    objekat.noviGrad = textBox1.Text;
            MessageBox.Show("Grad: " + textBox1.Text + " je uspešno dodat!");

            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addCity();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                addCity();
            }
        }


    }
}
