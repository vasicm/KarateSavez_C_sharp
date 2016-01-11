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
    public partial class PrikazTakmicara : Form
    {
        private Dictionary<string, ListViewGroup> grupe; 
        public PrikazTakmicara()
        {
            InitializeComponent();
            pretragaTextBox.AutoCompleteCustomSource.AddRange((string[])ClanDAO.imena().ToArray(typeof(string)));
            grupe = new Dictionary<string, ListViewGroup>();

            this.klubComboBox.SelectedIndexChanged -= new System.EventHandler(this.klubComboBox_SelectedIndexChanged);
            this.datumComboBox.SelectedIndexChanged -= new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            this.kategorijaComboBox.SelectedIndexChanged -= new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);

            this.klubComboBox.Items.AddRange(KarateKlubDAO.naziviKlubova().ToArray());
            this.klubComboBox.SelectedIndex = 0;  
                 
            this.takmicenjeComboBox.Items.AddRange(TakmicenjeDAO.naziviSvi().ToArray());
            this.takmicenjeComboBox.SelectedIndex = 0;

            this.datumComboBox.Enabled = false;
            this.kategorijaComboBox.Enabled = false;

            this.klubComboBox.SelectedIndexChanged += new System.EventHandler(this.klubComboBox_SelectedIndexChanged);
            this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);

            osvjezi();
        }


        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicara editovanjeTakicara = new EditovanjeTakmicara();
            try
            {
                DateTime dt;
                DateTime.TryParse(takmicariListView.SelectedItems[0].SubItems[5].Text, out dt);
                Clan clan = new Clan(
                    Convert.ToInt64(
                        takmicariListView.SelectedItems[0].SubItems[0].Text),
                        takmicariListView.SelectedItems[0].SubItems[1].Text,
                        takmicariListView.SelectedItems[0].SubItems[2].Text,
                        takmicariListView.SelectedItems[0].SubItems[4].Text,
                        dt,
                        takmicariListView.SelectedItems[0].SubItems[3].Text
                    );
                editovanjeTakicara.Clan = clan;
                editovanjeTakicara.Show();
            }
            catch (IndexOutOfRangeException ioorEx)
            {
                MessageBox.Show("Селектујте такмичара којег желите да прикажете");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeTakmicara editovanjeTakicara = new EditovanjeTakmicara();
            editovanjeTakicara.ShowDialog();
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void popuniListu(ArrayList clanovi)
        {
            this.takmicariListView.Items.Clear();
            foreach (Clan clan in clanovi)
            {
                if(grupe.ContainsKey(clan.Klub)==false)
                {
                    grupe[clan.Klub] = new System.Windows.Forms.ListViewGroup(clan.Klub, System.Windows.Forms.HorizontalAlignment.Left);
                    grupe[clan.Klub].Header = clan.Klub;
                    takmicariListView.Groups.Add(grupe[clan.Klub]);
                }
                ListViewItem lvi = clan.ListViewItem;
                lvi.Group = grupe[clan.Klub];
                this.takmicariListView.Items.Add(lvi);
            }
        }

        private void osvjezi()
        {
            string nazivKluba;
            string nazivTakmicenja;
            DateTime datumTakmicenja;
            string kategorija;
            ArrayList clanovi = new ArrayList();

            if (klubComboBox.SelectedIndex != 0)
            {
                nazivKluba = klubComboBox.SelectedItem.ToString();
            }
            else {
                nazivKluba = null;
            }

            if (takmicenjeComboBox.SelectedIndex == 0)
            {
                clanovi = ClanDAO.clanoviKluba(nazivKluba);
            }
            else
            {
                nazivTakmicenja = takmicenjeComboBox.SelectedItem.ToString();
                string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');
                if (this.kategorijaComboBox.Items.Count > 0)
                {
                    kategorija = kategorijaComboBox.SelectedItem.ToString();
                    clanovi = ClanDAO.clanovi(
                        nazivKluba, 
                        nazivTakmicenja, 
                        datum[2] + datum[1] + datum[0], 
                        kategorija
                    );
                }
            }

            popuniListu(clanovi);
        }

        private void kategorijaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void datumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.kategorijaComboBox.SelectedIndexChanged -= new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);

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

            this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);

            osvjezi();
        }

        private void takmicenjeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (takmicenjeComboBox.SelectedIndex == 0)
            {
                this.datumComboBox.Enabled = false;
                this.kategorijaComboBox.Enabled = false;
            }
            else
            {
                this.datumComboBox.SelectedIndexChanged -= new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
                this.kategorijaComboBox.SelectedIndexChanged -= new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);

                this.datumComboBox.Enabled = true;
                this.datumComboBox.Items.Clear();
                this.datumComboBox.Items.AddRange(
                    TakmicenjeDAO.datumiSvi(takmicenjeComboBox.SelectedItem.ToString()).ToArray()
                );

                this.datumComboBox.SelectedIndex = 0;

                this.kategorijaComboBox.Enabled = true;
                this.kategorijaComboBox.Items.Clear();
                string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');
                
                this.kategorijaComboBox.Items.AddRange(
                    TakmicenjeDAO.naziviKAtegorija(
                        takmicenjeComboBox.SelectedItem.ToString(), 
                        datum[2]+datum[1]+datum[0]
                    ).ToArray()
                );
                
                if (this.kategorijaComboBox.Items.Count > 0)
                {
                    this.kategorijaComboBox.SelectedIndex = 0;
                }

                this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
                this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);
            }
            osvjezi();
        }

        private void klubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void pretraziBtn_Click(object sender, EventArgs e)
        {
            ArrayList clanovi = ClanDAO.clanoviImePrezime(pretragaTextBox.Text);
            popuniListu(clanovi);
        }

        private void pretragaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            dbgLabel.Text = e.KeyData.ToString();
            if (e.KeyData == Keys.Enter)
            {
                ArrayList clanovi = ClanDAO.clanoviImePrezime(pretragaTextBox.Text);
                popuniListu(clanovi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Left;
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }
    }
}
