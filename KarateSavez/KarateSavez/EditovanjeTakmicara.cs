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

namespace KarateSavez
{
    public partial class EditovanjeTakmicara : Form
    {
        private Clan clan;
        public EditovanjeTakmicara()
        {
            InitializeComponent();

            this.klubComboBox.Items.AddRange(KarateKlubDAO.naziviKlubova().ToArray());
            this.klubComboBox.SelectedIndex = 0;
            this.pojasComboBox.SelectedIndex = 0;
        }

        internal Clan Clan
        {
            get
            {
                return clan;
            }

            set
            {
                clan = value;
                imeTxtBox.Text = clan.Ime;
                prezimeTxtBox.Text = clan.Prezime;
                klubComboBox.SelectedIndex = klubComboBox.Items.IndexOf(clan.Klub);
                pojasComboBox.SelectedIndex = pojasComboBox.Items.IndexOf(clan.Pojas);
                datumRodjenjadTPicker.Value = clan.GodinaRodjenja;
                jmbTxtBox.Text = clan.Jmb.ToString();
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            string ime = imeTxtBox.Text;
            string prezime = prezimeTxtBox.Text;
            string klub = klubComboBox.SelectedItem.ToString();
            string pojas = pojasComboBox.SelectedItem.ToString();
            DateTime datumRodjenja = datumRodjenjadTPicker.Value;
            long jmb;

            bool rezultat = false;

            try {
                jmb = Convert.ToInt64(jmbTxtBox.Text);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("ЈМБ није коректан", "Грешка!");
                return;
            }

            if (ime.Equals("") || prezime.Equals("") || klub.Equals("") || pojas.Equals(""))
            {
                MessageBox.Show("Попуните сва поља", "Грешка!");
                return;
            }

            Clan clan = new Clan(jmb, ime,prezime, pojas, datumRodjenja, klub);
            if (ClanDAO.sadrzi(jmb))
            {
                rezultat = ClanDAO.azuriraj(clan);
            }
            else
            {
                rezultat = ClanDAO.dodaj(clan);
            }
            if (rezultat)
            {
                MessageBox.Show("Такмичар је успјешно додан у базу", "Обавјештење!", MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("Догодила се грешка", "Обавјештење!", MessageBoxButtons.YesNo);
            }
            return;
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }
    }
}
