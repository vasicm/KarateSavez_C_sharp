﻿using System;
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
    public partial class PrikazBorbi : Form
    {
        public PrikazBorbi()
        {
            InitializeComponent();
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
            osvjezi();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да ли сте сигурни?", "Питање!", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void pomocBtn_Click(object sender, EventArgs e)
        {
            //TODO
            MessageBox.Show("Није имплементирано", "Обавјештење!", MessageBoxButtons.YesNo);
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            EditovanjeBorbe dialog = new EditovanjeBorbe();
            dialog.ShowDialog();
            osvjezi();
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {
            EditovanjeBorbe dialog = new EditovanjeBorbe();
            dialog.Borba = (Borba)borbeListView.SelectedItems[0];
            dialog.ShowDialog();
            osvjezi();
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void izbrisiBtn_Click(object sender, EventArgs e)
        {
            BorbaDAO.brisi((Borba)borbeListView.SelectedItems[0]);
            osvjezi();
        }

        private void osvjezi()
        {
            string nazivTakmmicenja = takmicenjeComboBox.SelectedItem.ToString();
            string datumTakmicenja = datumComboBox.SelectedItem.ToString();
            string kategorija = kategorijaComboBox.SelectedItem.ToString();
            string[] datum = datumComboBox.SelectedItem.ToString().Split(' ')[0].Split('/');

            borbeListView.Items.Clear();
            borbeListView.Items.AddRange((ListViewItem[])BorbaDAO.borbeSve(nazivTakmmicenja, datum[2] + datum[1] + datum[0], kategorija).ToArray(typeof(ListViewItem)));
        }
    }
}
