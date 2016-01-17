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

namespace KarateSavez
{
    public partial class PrijavaTakmicara : Form
    {
        long jmb;

        public long Jmb
        {
            get
            {
                return jmb;
            }

            set
            {
                jmb = value;
            }
        }

        public PrijavaTakmicara()
        {
            InitializeComponent();

            jmb = 0;
            this.takmicenjeComboBox.Items.AddRange(TakmicenjeDAO.naziviSvi().ToArray());
            this.takmicenjeComboBox.SelectedIndex = 0;
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
        }

        private void prijaviBtn_Click(object sender, EventArgs e)
        {
            string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');
            if (PrijavaDAO.prijavi(jmb, takmicenjeComboBox.SelectedItem.ToString(), datum[2] + datum[1] + datum[0], kategorijaComboBox.SelectedItem.ToString()) == true) MessageBox.Show("Успјешно сте пријавили такмичара");
            else MessageBox.Show("Догодила се грешка приликом пријаве такмичара");
        }
    }
}
