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
    public partial class DodajKategorijutereta : Form
    {
        DodajTransport otac;
        Form1 mainForm;
        SQLiteConnection sqlite;

        public DodajKategorijutereta()
        {
            InitializeComponent();
        }
        public DodajKategorijutereta(DodajTransport form1, SQLiteConnection conn, int flag)
        {
            InitializeComponent();
            this.otac = form1;
            sqlite = conn;
        }
        public DodajKategorijutereta(Form1 form1, SQLiteConnection conn)
        {
            InitializeComponent();
            this.mainForm = form1;
            sqlite = conn;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            SQLiteCommand add = sqlite.CreateCommand();
            add.CommandText = "insert into KATEGORIJA_TERETA (nazivKatTereta) values ('" + textBoxImeKategorije.Text + "');";
            add.ExecuteNonQuery();
            MessageBox.Show("Kategorija tereta: " + textBoxImeKategorije.Text + " je uspešno dodata!");
            this.Close();
        }
    }
}
