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
    public partial class pocetnaForma : Form
    {
        //private System.Windows.Forms.ListView listView1;

        public pocetnaForma()
        {
            InitializeComponent();
            //pripremiListuZaOglase();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void takmicenjaStripBtn_Click(object sender, EventArgs e)
        {
            Takmicenja takmicenjaDialog = new Takmicenja();
            //takmicenjaDialog.Dock = DockStyle.Right;
            takmicenjaDialog.MdiParent = this;
            takmicenjaDialog.Show();
        }

        private void pregletStripBtn_Click(object sender, EventArgs e)
        {
            PrikazTakmicara prikazTakicara = new PrikazTakmicara();
            //prikazTakicara.Dock = DockStyle.Left;
            prikazTakicara.MdiParent = this;
            prikazTakicara.Show();
        }

        private void prikaziTakmicare()
        {
            this.listView1.Clear();

            ColumnHeader jmbColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader imeColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader prezimeColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader klubColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader pojasColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ColumnHeader datumRodjenjaColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            jmbColHead.Text = "ЈМБ";
            imeColHead.Text = "Име";
            prezimeColHead.Text = "Презиме";
            klubColHead.Text = "Клуб";
            pojasColHead.Text = "Појас";
            datumRodjenjaColHead.Text = "Датум рођења";

            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                jmbColHead,
                imeColHead,
                prezimeColHead,
                klubColHead,
                pojasColHead,
                datumRodjenjaColHead});

            Dictionary<string, ListViewGroup>  grupe = new Dictionary<string, ListViewGroup>();
            ArrayList clanovi = ClanDAO.clanoviSvi();

            foreach (Clan clan in clanovi)
            {
                if (grupe.ContainsKey(clan.Klub) == false)
                {
                    grupe[clan.Klub] = new System.Windows.Forms.ListViewGroup(clan.Klub, System.Windows.Forms.HorizontalAlignment.Left);
                    grupe[clan.Klub].Header = clan.Klub;
                    listView1.Groups.Add(grupe[clan.Klub]);
                }
                ListViewItem lvi = clan.ListViewItem;
                lvi.Group = grupe[clan.Klub];
                this.listView1.Items.Add(lvi);
            }

        }

        private void prikaziOglase()
        {
            this.listView1.Clear();

            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Такмичење", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Друге активности", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Испит", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Куп Републике Српске",
            "Карате клуб ИПОН Прњавор организује куп Републике Српске који ће се одржати 22.3." +
                "2016. године у градској дворани.",
            "10.01.2016"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Првенстов Републике Српске",
            "Карате клуб Слога Добој организује куп Републике Српске који ће се одржати 16.4.2" +
                "016. године у градској дворани.",
            "11.01.2016."}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Љетни камп",
            "Карате клуб Леотар из требиња организује љетни спортски камп, који ће се одршати " +
                "у требињу и трајаће од 10.08.1016. до 20.08.2016.",
            "15.01.2016."}, -1);

            //this.listView1 = new System.Windows.Forms.ListView();

            // 
            // listView1
            // 
            //this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naslovColHead,
            this.tekstOglasaColHead,
            this.vrijemeObjaveColHead});
            listViewGroup1.Header = "Такмичење";
            listViewGroup1.Name = "takmicenjeListVG";
            listViewGroup2.Header = "Друге активности";
            listViewGroup2.Name = "drugeAktivnostiListVG";
            listViewGroup3.Header = "Испит";
            listViewGroup3.Name = "ispitListVG";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            //this.listView1.Location = new System.Drawing.Point(0, 53);
            //this.listView1.Name = "listView1";
            //this.listView1.Size = new System.Drawing.Size(892, 557);
            //this.listView1.TabIndex = 3;
            //this.listView1.UseCompatibleStateImageBehavior = false;
            //this.listView1.View = System.Windows.Forms.View.Details;
            //this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);

            //this.Controls.Add(this.listView1);
        }

        private void podesavanjaStripBtn_Click(object sender, EventArgs e)
        {
            prikaziTakmicare();
        }

        private void pocetnaStripBtn_Click(object sender, EventArgs e)
        {
            prikaziOglase();
        }
    }
}
