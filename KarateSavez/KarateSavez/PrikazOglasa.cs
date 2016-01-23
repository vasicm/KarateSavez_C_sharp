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
    public partial class PrikazOglasa : Form
    {
        private Dictionary<string, ListViewGroup> grupe;

        public PrikazOglasa()
        {
            InitializeComponent();
            grupe = new Dictionary<string, ListViewGroup>();
            popuniListu(OglasDAO.oglasiSvi());
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            popuniListu(OglasDAO.oglasiPoNaslovu(pretraziTextBox.Text));
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            popuniListu(OglasDAO.oglasiSvi());
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            if (oglasiListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Морате селектовати оглас који желите да избришете", "Обајештење!");
            }
            else
            {
                EditovanjeOglasa dialog = new EditovanjeOglasa();
                dialog.Oglas = (Oglas)oglasiListView.SelectedItems[0];
                dialog.ShowDialog();
                popuniListu(OglasDAO.oglasiSvi());
            }
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (oglasiListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Морате селектовати оглас који желите да избришете", "Обајештење!");
            }
            else if (MessageBox.Show("Да ли сте сигурни да желите да избришете селектовани оглас?", "Да ли сте сигурни?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (OglasDAO.brisi((Oglas)oglasiListView.SelectedItems[0]) == false)
                {
                    MessageBox.Show("Брисање није успјело", "Грешка!");
                }
            }
            popuniListu(OglasDAO.oglasiSvi());
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeOglasa dialog = new EditovanjeOglasa();
            dialog.ShowDialog();
            popuniListu(OglasDAO.oglasiSvi());
        }

        private void popuniListu(ArrayList oglasi)
        {
            this.oglasiListView.Items.Clear();

            foreach (Oglas oglas in oglasi)
            {
                if (grupe.ContainsKey(oglas.TipOglasa) == false)
                {
                    grupe[oglas.TipOglasa] = new ListViewGroup(oglas.TipOglasa, System.Windows.Forms.HorizontalAlignment.Left);
                    grupe[oglas.TipOglasa].Header = oglas.TipOglasa;
                    oglasiListView.Groups.Add(grupe[oglas.TipOglasa]);
                }
                oglas.Group = grupe[oglas.TipOglasa];
                oglasiListView.Items.Add(oglas);
            }
        }

        private void pretraziTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                popuniListu(OglasDAO.oglasiPoNaslovu(pretraziTextBox.Text));
            }
        }
    }
}
