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
    public partial class EditovanjeBorbe : Form
    {
        Borba borba;



        public EditovanjeBorbe()
        {
            InitializeComponent();

            borba = null;

            this.takmicenjeComboBox.Items.AddRange(TakmicenjeDAO.naziviSvi().ToArray());
            this.takmicenjeComboBox.SelectedIndex = 0;
        }

        internal Borba Borba
        {
            get
            {
                return borba;
            }

            set
            {
                borba = value;

                takmicenjeComboBox.SelectedIndex = takmicenjeComboBox.Items.IndexOf(borba.NazivTakmicenja);
                datumComboBox.SelectedIndex = datumComboBox.Items.IndexOf(borba.DatumTakmicenja.ToString());
                kategorijaComboBox.SelectedIndex = kategorijaComboBox.Items.IndexOf(borba.Kategorija);
                plaviComboBox.SelectedIndex = plaviComboBox.Items.IndexOf(borba.Plavi);
                crveniComboBox.SelectedIndex = crveniComboBox.Items.IndexOf(borba.Crveni);

                poeniPlaviNumericUpDown.Value = borba.PoeniPlavi;
                poeniCrveniNumericUpDown.Value = borba.PoeniCrveni;
                kaznePlaviNumericUpDown.Value = borba.KaznePlavi;
                kazneCrveniNumericUpDown.Value = borba.KazneCrveni;
                krugNumericUpDown.Value = borba.Krug;

            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            DateTime datumDT;
            DateTime.TryParse(datumComboBox.SelectedItem.ToString(), out datumDT);

            if (Borba == null)
            {
                Borba = new Borba(
                    takmicenjeComboBox.SelectedItem.ToString(),
                    datumDT,
                    kategorijaComboBox.SelectedItem.ToString(),
                    plaviComboBox.SelectedItem.ToString(),
                    crveniComboBox.SelectedItem.ToString(),
                    Convert.ToInt32(poeniPlaviNumericUpDown.Value),
                    Convert.ToInt32(poeniCrveniNumericUpDown.Value),
                    Convert.ToInt32(kaznePlaviNumericUpDown.Value),
                    Convert.ToInt32(kazneCrveniNumericUpDown.Value),
                    Convert.ToInt32(krugNumericUpDown.Value)
                );

                if (BorbaDAO.dodaj(borba) == true) this.Close();
                else MessageBox.Show("Догодила се грешка приликом додавања борбе у базу");
            }
            else
            {
                borba.NazivTakmicenja = takmicenjeComboBox.SelectedItem.ToString();
                borba.DatumTakmicenja = datumDT;
                borba.Kategorija = kategorijaComboBox.SelectedItem.ToString();
                borba.Plavi = plaviComboBox.SelectedItem.ToString();
                borba.Crveni = crveniComboBox.SelectedItem.ToString();
                borba.PoeniPlavi = Convert.ToInt32(poeniPlaviNumericUpDown.Value);
                borba.PoeniCrveni = Convert.ToInt32(poeniCrveniNumericUpDown.Value);
                borba.KaznePlavi = Convert.ToInt32(kaznePlaviNumericUpDown.Value);
                borba.KazneCrveni = Convert.ToInt32(kazneCrveniNumericUpDown.Value);
                borba.Krug = Convert.ToInt32(krugNumericUpDown.Value);

                if (BorbaDAO.azuriraj(borba) == true) MessageBox.Show("Успјешно сте ажурирали борбу");
                else MessageBox.Show("Догодила се грешка приликом ажурирања борбе");
            }

        }

        private void takmicenjeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.datumComboBox.Enabled = true;
            this.datumComboBox.Items.Clear();
            this.datumComboBox.Items.AddRange(
                TakmicenjeDAO.datumiSvi(takmicenjeComboBox.SelectedItem.ToString()).ToArray()
            );
            if (this.datumComboBox.Items.Count > 0)
            {
                this.datumComboBox.SelectedIndex = 0;
            }
            else
            {
                this.kategorijaComboBox.Enabled = false;
                this.datumComboBox.Enabled = false;
            }
        }

        private void datumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.kategorijaComboBox.Enabled = true;
            this.kategorijaComboBox.Items.Clear();
            string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');
            this.kategorijaComboBox.Items.AddRange(
                TakmicenjeDAO.naziviKAtegorija(
                    takmicenjeComboBox.SelectedItem.ToString(),
                    datum[2] + datum[1] + datum[0]
                    ).ToArray()
            );

            if (this.kategorijaComboBox.Items.Count > 0)
            {
                this.kategorijaComboBox.SelectedIndex = 0;
            }
        }

        private void kategorijaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nazivTakmicenja = takmicenjeComboBox.SelectedItem.ToString();
            string datumTakmicenja = datumComboBox.SelectedItem.ToString();
            string kategorija = kategorijaComboBox.SelectedItem.ToString();
            string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');

            ArrayList clanovi = ClanDAO.clanovi(null, nazivTakmicenja, datum[2] + datum[1] + datum[0], kategorija);

            plaviComboBox.Items.Clear();
            crveniComboBox.Items.Clear();
            

            foreach (Clan clan in clanovi)
            {
                plaviComboBox.Items.Add(clan.ToString());
                crveniComboBox.Items.Add(clan.ToString());
            }

            if (clanovi.Count != 0)
            {
                plaviComboBox.SelectedIndex = 0;
                crveniComboBox.SelectedIndex = 0;
            }

        }
    }
}
