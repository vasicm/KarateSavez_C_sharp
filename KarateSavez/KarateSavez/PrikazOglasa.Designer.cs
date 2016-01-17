namespace KarateSavez
{
    partial class PrikazOglasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pretraziTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pretraziBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.dodajBtn = new System.Windows.Forms.ToolStripButton();
            this.izbrisiBtn = new System.Windows.Forms.ToolStripButton();
            this.prikaziBtn = new System.Windows.Forms.ToolStripButton();
            this.osvjeziBtn = new System.Windows.Forms.ToolStripButton();
            this.oglasiListView = new System.Windows.Forms.ListView();
            this.naslovColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tekstOglasaColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vrijemeObjaveColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.pretraziTextBox,
            this.pretraziBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel1.Text = "Претражи:";
            // 
            // pretraziTextBox
            // 
            this.pretraziTextBox.Name = "pretraziTextBox";
            this.pretraziTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pretraziBtn.Image = global::KarateSavez.Properties.Resources.search;
            this.pretraziBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(23, 22);
            this.pretraziBtn.Text = "toolStripButton1";
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajBtn,
            this.izbrisiBtn,
            this.prikaziBtn,
            this.osvjeziBtn});
            this.toolStrip5.Location = new System.Drawing.Point(0, 25);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(853, 25);
            this.toolStrip5.TabIndex = 26;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Image = global::KarateSavez.Properties.Resources.new1;
            this.dodajBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(57, 22);
            this.dodajBtn.Text = "Додај";
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Image = global::KarateSavez.Properties.Resources.help;
            this.izbrisiBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(80, 22);
            this.izbrisiBtn.Text = "Избриши";
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Image = global::KarateSavez.Properties.Resources.open;
            this.prikaziBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(78, 22);
            this.prikaziBtn.Text = "Прикажи";
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // osvjeziBtn
            // 
            this.osvjeziBtn.Image = global::KarateSavez.Properties.Resources.reload;
            this.osvjeziBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.osvjeziBtn.Name = "osvjeziBtn";
            this.osvjeziBtn.Size = new System.Drawing.Size(107, 22);
            this.osvjeziBtn.Text = "Освјежи листу";
            this.osvjeziBtn.Click += new System.EventHandler(this.osvjeziBtn_Click);
            // 
            // oglasiListView
            // 
            this.oglasiListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oglasiListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naslovColHead,
            this.tekstOglasaColHead,
            this.vrijemeObjaveColHead});
            listViewGroup1.Header = "Такмичење";
            listViewGroup1.Name = "takmicenjeListVG";
            listViewGroup2.Header = "Друге активности";
            listViewGroup2.Name = "drugeAktivnostiListVG";
            listViewGroup3.Header = "Испит";
            listViewGroup3.Name = "ispitListVG";
            this.oglasiListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            this.oglasiListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.oglasiListView.Location = new System.Drawing.Point(0, 46);
            this.oglasiListView.Name = "oglasiListView";
            this.oglasiListView.Size = new System.Drawing.Size(853, 437);
            this.oglasiListView.TabIndex = 27;
            this.oglasiListView.UseCompatibleStateImageBehavior = false;
            this.oglasiListView.View = System.Windows.Forms.View.Details;
            // 
            // naslovColHead
            // 
            this.naslovColHead.Text = "Наслов огласа";
            this.naslovColHead.Width = 229;
            // 
            // tekstOglasaColHead
            // 
            this.tekstOglasaColHead.Text = "Текст огласа";
            this.tekstOglasaColHead.Width = 492;
            // 
            // vrijemeObjaveColHead
            // 
            this.vrijemeObjaveColHead.Text = "Вријеме објаве";
            this.vrijemeObjaveColHead.Width = 96;
            // 
            // PrikazOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 482);
            this.Controls.Add(this.oglasiListView);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrikazOglasa";
            this.Text = "PrikazOglasa";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox pretraziTextBox;
        private System.Windows.Forms.ToolStripButton pretraziBtn;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton dodajBtn;
        private System.Windows.Forms.ToolStripButton izbrisiBtn;
        private System.Windows.Forms.ToolStripButton prikaziBtn;
        private System.Windows.Forms.ToolStripButton osvjeziBtn;
        private System.Windows.Forms.ListView oglasiListView;
        private System.Windows.Forms.ColumnHeader naslovColHead;
        private System.Windows.Forms.ColumnHeader tekstOglasaColHead;
        private System.Windows.Forms.ColumnHeader vrijemeObjaveColHead;
    }
}