using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KarateSavez.dto;
using KarateSavez.dao;

namespace KarateSavez
{
    public partial class EditovanjeTakmicenja : Form
    {
        private Takmicenje takmicenje;

        public EditovanjeTakmicenja()
        {
            InitializeComponent();
            takmicenje = null;
            organizatorComboBox.Items.AddRange((string [])KarateKlubDAO.naziviKlubova().ToArray(typeof(string)));
        }

        internal Takmicenje Takmicenje
        {
            get
            {
                return takmicenje;
            }

            set
            {
                takmicenje = value;
                nazivTxtBox.Text = takmicenje.Naziv;
                datumPocetkaDateTimePicker.Value = takmicenje.Datum;
                organizatorComboBox.SelectedIndex = organizatorComboBox.Items.IndexOf(takmicenje.Organizator);
                adresaTxtBox.Text = takmicenje.Adresa;
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            string nazivTakmicenja = nazivTxtBox.Text;
            object organizator = organizatorComboBox.SelectedItem;
            string adresa = adresaTxtBox.Text;

            if (nazivTakmicenja.Equals("") || organizator == null || adresa.Equals(""))
            {
                MessageBox.Show("Морате попунити сва поља", "Обајвештење!");
                return;
            }

            if (Takmicenje == null)
            {
                Takmicenje = new Takmicenje(
                    0,
                    nazivTxtBox.Text,
                    datumPocetkaDateTimePicker.Value,
                    organizatorComboBox.SelectedItem.ToString(),
                    adresaTxtBox.Text
                );
                if (TakmicenjeDAO.dodaj(Takmicenje) == true) this.Close();
                else MessageBox.Show("Додавање није успјело", "Грешка!");
            }
            else
            {
                takmicenje.Naziv = nazivTxtBox.Text;
                takmicenje.Datum = datumPocetkaDateTimePicker.Value;
                takmicenje.Organizator = organizatorComboBox.SelectedItem.ToString();
                takmicenje.Adresa = adresaTxtBox.Text;

                if (TakmicenjeDAO.azuriraj(Takmicenje) == true) this.Close();
                else MessageBox.Show("Ажурирање није успјело", "Грешка!");
            }
        }
    }
}
