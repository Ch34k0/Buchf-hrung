using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Buchführung
{
    public partial class Eingabe : Form
    {
        OleDbConnection DB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Datenbank.accdb;Persist Security Info=False");
        public Eingabe()
        {
            InitializeComponent();
            DB.Open();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            DB.Close();
            this.Close();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            double Wert = new double();
            if (radioEinnahme.Checked)
            {
                Wert = (double)numericBetrag.Value;
            }
            else
            {
                Wert = (double)numericBetrag.Value * -1;
            }

            if(textBoxGrund.Text == String.Empty)
            {
                MessageBox.Show("Bitte geben Sie einen Grund oder eine Bezeichnung ein!");
                textBoxGrund.Focus();
                return;
            }


            In_Datenbank_eingeben(textBoxGrund.Text, Wert, dateDatum.Value.ToString());

            numericBetrag.Value = 0;
            textBoxGrund.Clear();
            dateDatum.Value = DateTime.Now;
        }
        
        void In_Datenbank_eingeben(string Grund, double Wert, string Datum)
        {
            OleDbCommand CMD = new OleDbCommand("INSERT INTO Finanz (Grund, Wert, Datum) VALUES ('" + Grund + "', '" + Wert + "', '" + Datum + "')", DB);
            CMD.ExecuteNonQuery();
        }
    }
}
