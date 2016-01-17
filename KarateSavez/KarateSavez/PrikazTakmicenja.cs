using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using KarateSavez.dao;
using KarateSavez.dto;

namespace KarateSavez
{
    public partial class PrikazTakmicenja : Form
    {
        public PrikazTakmicenja()
        {
            InitializeComponent();
            popuniListu(TakmicenjeDAO.takmicenjaSva());
            pretraziTextBox.AutoCompleteCustomSource.AddRange((string[])TakmicenjeDAO.naziviSvi().ToArray(typeof(string)));
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
            dialog.ShowDialog();
            popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
            dialog.Takmicenje = (Takmicenje)takmicenjaListView.SelectedItems[0];
            dialog.ShowDialog();
            popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            Takmicenje takmicenje = (Takmicenje)takmicenjaListView.SelectedItems[0];
            if (TakmicenjeDAO.brisi(takmicenje) == true)
            {
                MessageBox.Show("Успјешно сте избрисали такмичење "+ takmicenje.Naziv);
            }
            else
            {
                MessageBox.Show("Дошло је до грешке приликом брисања такмичења " + takmicenje.Naziv);
            }
            popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
        }
        private void popuniListu(ArrayList takmicenja)
        {
            takmicenjaListView.Items.Clear();
            takmicenjaListView.Items.AddRange((ListViewItem[])takmicenja.ToArray(typeof(ListViewItem)));
        }

        private void pretraziTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
            }
        }
    }
}
