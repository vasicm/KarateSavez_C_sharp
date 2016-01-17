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
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            popuniListu(OglasDAO.oglasiSvi());
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            EditovanjeOglasa dialog = new EditovanjeOglasa();
            dialog.Oglas = (Oglas)oglasiListView.SelectedItems[0];
            dialog.ShowDialog();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни да желите да избришете селектовани оглас?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (OglasDAO.brisi((Oglas)oglasiListView.SelectedItems[0]) == true)
                {
                    MessageBox.Show("Успјешно сте избрисали оглас");
                }
                else
                {
                    MessageBox.Show("Брисање није успјело");
                }
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeOglasa dialog = new EditovanjeOglasa();
            dialog.ShowDialog();
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
    }
}
