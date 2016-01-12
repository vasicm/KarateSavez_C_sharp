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
        
        private void tmp1(object sender, EventArgs e)
        {
            PrikazBorbi takmicenjaDialog = new PrikazBorbi();
            //takmicenjaDialog.Dock = DockStyle.Right;
            takmicenjaDialog.MdiParent = this;
            takmicenjaDialog.Show();
        }

        private void tmp2(object sender, EventArgs e)
        {
            PrikazTakmicara prikazTakicara = new PrikazTakmicara();
            //prikazTakicara.Dock = DockStyle.Left;
            prikazTakicara.MdiParent = this;
            prikazTakicara.Show();
        }

        private void oglasiStripBtn_Click(object sender, EventArgs e)
        {
            PrikazOglasa forma = new PrikazOglasa();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void takmicenjaStripBtn_Click(object sender, EventArgs e)
        {
            PrikazTakmicenja forma = new PrikazTakmicenja();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void borbaStripBtn_Click(object sender, EventArgs e)
        {
            PrikazBorbi forma = new PrikazBorbi();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void takmicariStripBtn_Click(object sender, EventArgs e)
        {
            PrikazTakmicara forma = new PrikazTakmicara();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
    }
}
