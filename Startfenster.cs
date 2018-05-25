using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchführung
{
    public partial class Startfenster : Form
    {
        
        public Startfenster()
        {
            InitializeComponent();            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEingabe_Click(object sender, EventArgs e)
        {
            new Eingabe().ShowDialog();        
        }

        private void buttonAusgabe_Click(object sender, EventArgs e)
        {
            new Ausgabe().ShowDialog();
        }       
    }
}
