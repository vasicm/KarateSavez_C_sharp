using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KarateSavez.dao;
using KarateSavez.dto;
using System.Collections;

namespace KarateSavez
{
    public partial class pocetnaForma : Form
    {
        //private System.Windows.Forms.ListView listView1;

        public pocetnaForma()
        {
            InitializeComponent();
            //pripremiListuZaOglase();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oglasiStripBtn_Click(object sender, EventArgs e)
        {
            zatvoriSveForme();
            PrikazOglasa forma = new PrikazOglasa();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;

            forma.Show();
        }

        private void takmicenjaStripBtn_Click(object sender, EventArgs e)
        {
            zatvoriSveForme();
            PrikazTakmicenja forma = new PrikazTakmicenja();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void borbaStripBtn_Click(object sender, EventArgs e)
        {
            zatvoriSveForme();
            PrikazBorbi forma = new PrikazBorbi();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void takmicariStripBtn_Click(object sender, EventArgs e)
        {
            zatvoriSveForme();
            PrikazTakmicara forma = new PrikazTakmicara();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void oglasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditovanjeOglasa dialog = new EditovanjeOglasa();
            dialog.ShowDialog();
        }

        private void takmicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicara editovanjeTakicara = new EditovanjeTakmicara();
            editovanjeTakicara.ShowDialog();
        }

        private void takmicenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
            dialog.ShowDialog();
        }

        private void oglasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazOglasa forma = new PrikazOglasa();
            forma.Show();
        }

        private void takmicaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazTakmicara forma = new PrikazTakmicara();
            forma.WindowState = FormWindowState.Normal;
            forma.Show();
        }

        private void takmicenjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrikazTakmicenja forma = new PrikazTakmicenja();
            forma.Show();
        }

        private void zatvoriSveForme()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void temaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!");
        }

        private void dodatnaPodesavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!");
        }

        private void uputstvoZaKoriscenjeAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!");
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!");
        }

        private void oKarateSavezuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!");
        }
    }
}
