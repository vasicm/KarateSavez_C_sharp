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
        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if (Takmicenje == null)
            {
                Takmicenje = new Takmicenje(
                    0,
                    nazivTxtBox.Text,
                    datumPocetkaDateTimePicker.Value,
                    organizatorComboBox.SelectedItem.ToString(),
                    adresaTxtBox.Text
                );
                if (TakmicenjeDAO.dodaj(Takmicenje) == true) MessageBox.Show("Успјешно сте додали такмичара у базу");
                else MessageBox.Show("Догодила се грешка приликом додавања такмичара у базу");
            }
            else
            {
                takmicenje.Naziv = nazivTxtBox.Text;
                takmicenje.Datum = datumPocetkaDateTimePicker.Value;
                takmicenje.Organizator = organizatorComboBox.SelectedItem.ToString();
                takmicenje.Adresa = adresaTxtBox.Text;

                if (TakmicenjeDAO.azuriraj(Takmicenje) == true) MessageBox.Show("Успјешно сте ажурирали такмичара у базу");
                else MessageBox.Show("Догодила се грешка приликом ажурирања");
            }
        }
    }
}
