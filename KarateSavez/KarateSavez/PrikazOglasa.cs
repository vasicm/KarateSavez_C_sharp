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
    public partial class PrikazOglasa : Form
    {
        public PrikazOglasa()
        {
            InitializeComponent();
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeOglasa dialog = new EditovanjeOglasa();
            dialog.ShowDialog();
        }
    }
}
