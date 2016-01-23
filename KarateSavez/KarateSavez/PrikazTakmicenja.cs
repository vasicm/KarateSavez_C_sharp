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
            if (takmicenjaListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Морате селектовати такмичење које желите да прикажете", "Обајештење!");
            }
            else
            { 
                EditovanjeTakmicenja dialog = new EditovanjeTakmicenja();
                dialog.Takmicenje = (Takmicenje)takmicenjaListView.SelectedItems[0];
                dialog.ShowDialog();
                popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
            }
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (takmicenjaListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Морате селектовати такмичење које желите да избришете", "Обајештење!");
            }
            else if (MessageBox.Show("Да ли сте сигурни да желите да избришете селектовано такмичење?", "Да ли сте сигурни?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Takmicenje takmicenje = (Takmicenje)takmicenjaListView.SelectedItems[0];
                if (TakmicenjeDAO.brisi(takmicenje) == false)
                {
                    MessageBox.Show("Да бист избрисали такмичење " + takmicenje.Naziv + " морате одјавити све такмичаре", "Обајештење!");
                }
                popuniListu(TakmicenjeDAO.takmicenjaPretraga(pretraziTextBox.Text));
            }
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
