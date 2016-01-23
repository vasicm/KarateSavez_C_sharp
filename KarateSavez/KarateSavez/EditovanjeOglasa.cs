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
    public partial class EditovanjeOglasa : Form
    {
        Oglas oglas;

        public EditovanjeOglasa()
        {
            InitializeComponent();
            datumOglasaDateTimePicker.Value = DateTime.Today;
            datumOglasaDateTimePicker.Enabled = false;
            oglas = null;
        }

        internal Oglas Oglas
        {
            get
            {
                return oglas;
            }

            set
            {
                oglas = value;
                naslovTxtBox.Text = oglas.NaslovOglasa;
                tekstOglasaRichTextBox.Text = oglas.TekstOglasa;
                datumOglasaDateTimePicker.Value = oglas.DatumOglasa;
                datumOglasaDateTimePicker.Enabled = false;
                tipOglasaTxtBox.Text = oglas.Group.Header;
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            string naslovOglasa = naslovTxtBox.Text;
            string tekstOglasa = tekstOglasaRichTextBox.Text;
            string tipOglasas = tipOglasaTxtBox.Text;

            if (naslovOglasa.Equals("") || tekstOglasa.Equals("") || tipOglasas.Equals(""))
            {
                MessageBox.Show("Морате попунити сва поља", "Обајвештење!");
                return;
            }

            if (oglas == null)
            {
                Oglas oglas = new Oglas(0, naslovTxtBox.Text, tekstOglasaRichTextBox.Text, datumOglasaDateTimePicker.Value, tipOglasaTxtBox.Text);
                if (OglasDAO.dodaj(oglas) == true) this.Close();
                else MessageBox.Show("Додавање није успјело", "Грешка!");
            }
            else
            {
                oglas.NaslovOglasa = naslovTxtBox.Text;
                oglas.TekstOglasa = tekstOglasaRichTextBox.Text;
                oglas.DatumOglasa = datumOglasaDateTimePicker.Value;
                oglas.TipOglasa = tipOglasaTxtBox.Text;

                if (OglasDAO.azuriraj(oglas) == true) this.Close();
                else MessageBox.Show("Ажурирање није успјело", "Грешка!");
            }
        }

    }
}
