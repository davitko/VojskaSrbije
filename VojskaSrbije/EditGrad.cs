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
    public partial class EditGrad : Form
    {

        Form1 form1;
        VidiGrad mainFormGrad;
        SQLiteConnection sqlite;

        String idGrada = "nepoznato";
        String imeGrada = "nepoznato";

        public EditGrad()
        {
            InitializeComponent();
        }
        public EditGrad(Form1 form1, SQLiteConnection conn, String idGrada, String imeGrada)
        {
            InitializeComponent();
            this.form1 = form1;
            sqlite = conn;
            this.idGrada = idGrada;
            this.imeGrada = imeGrada;
            populateFields();
        }
        public EditGrad(VidiGrad formGrad, SQLiteConnection conn, String idGrada, String imeGrada)
        {
            InitializeComponent();
            this.mainFormGrad = formGrad;
            sqlite = conn;
            this.idGrada = idGrada;
            this.imeGrada = imeGrada;
            populateFields();
        }
        public void populateFields()
        {
            textBoxImeGrada.Text = imeGrada;             
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (imeGrada == textBoxImeGrada.Text)
            {
                MessageBox.Show("Nista niste izmenili!", "Upozorenje");
                return;
            }
            else
            {
                SQLiteCommand update = sqlite.CreateCommand();
                update.CommandText = "UPDATE GRAD SET imeGrada='" + textBoxImeGrada.Text + "' WHERE gradID=" + idGrada + ";";
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Uspesno se azuirirali grad sa: " + imeGrada + " na: " + textBoxImeGrada.Text, "Obavestenje");
                    mainFormGrad.populateDropDown();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nije uspelo azuriranje grada sa: " + imeGrada + " na: " + textBoxImeGrada.Text, "Upozorenje");
                    return;
                }
               
            }
          
        }
    }
}
