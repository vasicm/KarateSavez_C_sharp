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
            if (oglas == null)
            {
                Oglas oglas = new Oglas(0, naslovTxtBox.Text, tekstOglasaRichTextBox.Text, datumOglasaDateTimePicker.Value, tipOglasaTxtBox.Text);
                if (OglasDAO.dodaj(oglas) == true)
                {
                    MessageBox.Show("Успјешно сте додали оглас");
                }
                else
                {
                    MessageBox.Show("Додавање није успјело");
                }
            }
            else
            {
                oglas.NaslovOglasa = naslovTxtBox.Text;
                oglas.TekstOglasa = tekstOglasaRichTextBox.Text;
                oglas.DatumOglasa = datumOglasaDateTimePicker.Value;
                oglas.TipOglasa = tipOglasaTxtBox.Text;

                if (OglasDAO.azuriraj(oglas) == true)
                {
                    MessageBox.Show("Успјешно сте ажурирали оглас");
                }
                else
                {
                    MessageBox.Show("Ажурирање није успјело");
                }
            }
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }
    }
}
