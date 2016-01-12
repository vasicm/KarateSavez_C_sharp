using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateSavez
{
    public partial class PrikazTakmicenja : Form
    {
        public PrikazTakmicenja()
        {
            InitializeComponent();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
            dialog.ShowDialog();
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
            dialog.ShowDialog();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }
    }
}
