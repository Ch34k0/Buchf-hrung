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
    public partial class Ausgabe : Form
    {
        OleDbConnection DB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Datenbank.accdb;Persist Security Info=False");
        public Ausgabe()
        {
            InitializeComponent();

            richTextAusgabe.Font = new Font(FontFamily.GenericMonospace, richTextAusgabe.Font.Size);
            richTextEinnahme.Font = new Font(FontFamily.GenericMonospace, richTextEinnahme.Font.Size);
            richTextSalden.Font = new Font(FontFamily.GenericMonospace, richTextSalden.Font.Size);
            richTextJahr.Font = new Font(FontFamily.GenericMonospace, richTextEinnahme.Font.Size);
            richTextVergleich.Font = new Font(FontFamily.GenericMonospace, richTextSalden.Font.Size);
                        
            DB.Open();            
        }

        private void Ausgabe_Load(object sender, EventArgs e)
        {
            comboBoxJahr.Items.Clear();
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                comboBoxJahr.Items.Add(i.ToString());
            }

            comboBoxVergleich.Items.Clear();
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                comboBoxVergleich.Items.Add(i.ToString());
            }

            comboBoxMonat.SelectedIndex = 11;
            comboBoxVergleich.SelectedIndex = comboBoxVergleich.Items.Count - 1;
            comboBoxJahr.SelectedIndex = comboBoxJahr.Items.Count - 1;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auslesen();
        }

        private void comboBoxJahr_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Auslesen();
        }

        private void comboBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auslesen();
        }

        private void comboBoxVergleich_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auslesen();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {            
            DB.Close();            
            this.Close();
        }

        void Auslesen()
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    comboBoxMonat.Show();
                    labelMonat.Show();
                    comboBoxVergleich.Hide();
                    labelVergleich.Hide();
                    Auslesen_pro_Monat();
                    break;
                case 1:
                    comboBoxMonat.Hide();
                    labelMonat.Hide();
                    comboBoxVergleich.Hide();
                    labelVergleich.Hide();
                    Auslesen_Salden();
                    break;
                case 2:
                    comboBoxMonat.Hide();
                    labelMonat.Hide();
                    comboBoxVergleich.Show();
                    labelVergleich.Show();
                    Auslesen_Vergleich();
                    break;

            }
        }

        void Auslesen_pro_Monat()
        {
            List<string> Minus = new List<string>();
            List<string> Plus = new List<string>();
            double Saldo = new int(), SummeEin = new int(), SummeAus = new int();
            string[] Monat_Liste = new string[12] {
            "01", "02", "03", "04",
            "05","06","07","08",
            "09","10","11","12"};
            string Monat = Monat_Liste[comboBoxMonat.SelectedIndex];
            DataTable DTA = Aus_Datenbank_auslesen();
            Minus = Ausgaben(DTA, Monat);
            Plus = Einnahmen(DTA, Monat);
            SummeEin = Summe_Einnahme(DTA, Monat);
            SummeAus = Summe_Ausgaben(DTA, Monat);
            Saldo = SummeEin + SummeAus;

            labelSummeEin.Text = "Summe = " + String.Format("{0:C}", SummeEin); ;
            labelSummeAus.Text = "Summe = " + String.Format("{0:C}", SummeAus); ;
            labelSaldo.Text = "Saldo = " + String.Format("{0:C}", Saldo);
            richTextAusgabe.Clear();
            richTextEinnahme.Clear();

            foreach (string Zeile in Minus)
            {
                richTextAusgabe.Text += Zeile + Environment.NewLine;
            }

            foreach (string Zeile in Plus)
            {
                richTextEinnahme.Text += Zeile + Environment.NewLine;
            }
        }

        void Auslesen_Salden()
        {
            double[,] Salden = new double[13, 3000];
            string[] Monat_Liste = new string[13] {
            "","Januar", "Februar","März","April",
                "Mai","Juni","Juli","August",
                "September","Oktober","November","Dezember"};
            string Laenge;
            DataTable DTA = Aus_Datenbank_auslesen();
            Salden = Salden_errechnen(DTA, Convert.ToInt32(comboBoxJahr.Text));

            richTextSalden.Clear();
            for (int Jahr = Convert.ToInt32(comboBoxJahr.Text); Jahr <= DateTime.Now.Year; Jahr++)
            {
                for (int Monat = 1; Monat < 13; Monat++)
                {
                    Laenge = Monat_Liste[Monat];
                    while (Laenge.Length < 10)
                    {
                        Laenge += " ";
                    }
                    Laenge += Jahr + ": ";
                    while (Laenge.Length < 16)
                    {
                        Laenge += " ";
                    }
                    richTextSalden.Text += Laenge + String.Format("{0:C}", Salden[Monat, Jahr]) + Environment.NewLine;
                }
            }
            richTextSalden.Text = richTextSalden.Text.Substring(0, richTextSalden.Text.Length - 1);
        }

        void Auslesen_Vergleich()
        {
            double SaldoJahr = 0, SaldoVergleich = 0;
            double[,] Salden = new double[13, 3000];
            string[] Monat_Liste = new string[13] {
            "","Januar", "Februar","März","April",
                "Mai","Juni","Juli","August",
                "September","Oktober","November","Dezember"};
            DataTable DTA = Aus_Datenbank_auslesen();
            Salden = Salden_errechnen(DTA, Convert.ToInt32(comboBoxJahr.Text));
            richTextJahr.Clear();
            Jahr_zeigen(Monat_Liste, Convert.ToInt32(comboBoxJahr.Text), Salden);
            Salden = Salden_errechnen(DTA, Convert.ToInt32(comboBoxVergleich.Text));
            richTextVergleich.Clear();
            Vergleich_zeigen(Monat_Liste, Convert.ToInt32(comboBoxVergleich.Text), Salden);

            SaldoJahr = Saldo_fuer_Jahr(DTA, Convert.ToInt32(comboBoxJahr.Text));
            SaldoVergleich = Saldo_fuer_Jahr(DTA, Convert.ToInt32(comboBoxVergleich.Text));

            labelSaldoJahr.Text = "Saldo = " + String.Format("{0:C}", SaldoJahr);
            labelSaldoVergleich.Text = "Saldo = " + String.Format("{0:C}", SaldoVergleich);

            labelJahr1.Text = comboBoxJahr.Text;
            labelJahr2.Text = comboBoxVergleich.Text;
        }

        void Jahr_zeigen(string[] Monat_Liste, int Jahr, double[,] Salden)
        {
            string Laenge;
            for (int Monat = 1; Monat < 13; Monat++)
            {
                Laenge = Monat_Liste[Monat] + ": ";
                while (Laenge.Length < 15)
                {
                    Laenge += " ";
                }
                richTextJahr.Text += Laenge + String.Format("{0:C}", Salden[Monat, Jahr]) + Environment.NewLine;
            }            
        }

        void Vergleich_zeigen(string[] Monat_Liste, int Jahr, double[,] Salden)
        {
            string Laenge;
            for (int Monat = 1; Monat < 13; Monat++)
            {
                Laenge = Monat_Liste[Monat] + ": ";
                while (Laenge.Length < 15)
                {
                    Laenge += " ";
                }
                richTextVergleich.Text += Laenge + String.Format("{0:C}", Salden[Monat, Jahr]) + Environment.NewLine;
            }
        }


        DataTable Aus_Datenbank_auslesen()
        {
            OleDbCommand CMD = new OleDbCommand("SELECT * FROM Finanz", DB);
            OleDbDataReader Leser = CMD.ExecuteReader();
            DataTable DTA = new DataTable();
            DTA.Load(Leser);
            return DTA;
        }

        List<string> Ausgaben(DataTable DTA, string Monat)
        {
            List<string> Minus = new List<string>();
            string Laenge;
            foreach (DataRow row in DTA.Rows)
            {

                if (Convert.ToDouble(row["Wert"].ToString()) < 0
                    && row["Datum"].ToString().Substring(6, 4) == comboBoxJahr.Text
                    && row["Datum"].ToString().Substring(3, 2) == Monat
                    )
                {
                    Laenge = String.Format("{0:C}", Convert.ToDouble(row["Wert"].ToString()));
                    while (Laenge.Length < 12)
                    {
                        Laenge += " ";
                    }
                    Laenge += (row["Grund"]).ToString();

                    Minus.Add(Laenge);
                }
            }
            return Minus;
        }

        List<string> Einnahmen(DataTable DTA, string Monat)
        {
            List<string> Plus = new List<string>();
            string Laenge;
            foreach (DataRow row in DTA.Rows)
            {                
                if (Convert.ToDouble(row["Wert"].ToString()) >= 0
                   && row["Datum"].ToString().Substring(6, 4) == comboBoxJahr.Text
                   && row["Datum"].ToString().Substring(3, 2) == Monat
                   )
                {
                    Laenge = String.Format("{0:C}", Convert.ToDouble(row["Wert"].ToString()));
                    while (Laenge.Length < 12)
                    {
                        Laenge += " ";
                    }
                    Laenge += (row["Grund"]).ToString();

                    Plus.Add(Laenge);
                }
            }
            return Plus;
        }

        double Summe_Einnahme(DataTable DTA, string Monat)
        {
            double SummeEin = new double();
            foreach (DataRow row in DTA.Rows)
            {
                if (Convert.ToDouble(row["Wert"].ToString()) >= 0
                   && row["Datum"].ToString().Substring(6, 4) == comboBoxJahr.Text
                   && row["Datum"].ToString().Substring(3, 2) == Monat
                   )
                {
                    SummeEin += Convert.ToDouble(row["Wert"].ToString());
                }
            }
            return SummeEin;
        }

        double Summe_Ausgaben(DataTable DTA, string Monat)
        {
            double SummeAus = new double();
            foreach (DataRow row in DTA.Rows)
            {
                if (Convert.ToDouble(row["Wert"].ToString()) < 0
                    && row["Datum"].ToString().Substring(6, 4) == comboBoxJahr.Text
                    && row["Datum"].ToString().Substring(3, 2) == Monat
                    )
                {
                    SummeAus += Convert.ToDouble(row["Wert"].ToString());
                }
            }
            return SummeAus;
        }

        double Saldo_fuer_Jahr(DataTable DTA, int Maximum)
        {
            double SaldoJahr = 0;
            int Jahr_Eintrag = 0;
            foreach (DataRow row in DTA.Rows)
            {
                Jahr_Eintrag = Convert.ToInt32(row["Datum"].ToString().Substring(6, 4));
                if (Jahr_Eintrag == Maximum)
                {
                    SaldoJahr += Convert.ToDouble(row["Wert"].ToString());
                }
            }

            return SaldoJahr;
        }

        double[,] Salden_errechnen(DataTable DTA, int Maximum)
        {
            int Monat_Eintrag = 0, Jahr_Eintrag = 0;
            double[,] Salden = new double[13, 3000];
            foreach (DataRow row in DTA.Rows)
            {
                Monat_Eintrag = Convert.ToInt32(row["Datum"].ToString().Substring(3, 2));
                Jahr_Eintrag = Convert.ToInt32(row["Datum"].ToString().Substring(6, 4));
                if (Jahr_Eintrag >= Maximum)
                {
                    Salden[Monat_Eintrag, Jahr_Eintrag] += Convert.ToDouble(row["Wert"].ToString());
                }
            }
            return Salden;
        }
    }
}