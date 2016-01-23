using System;

namespace KarateSavez
{
    partial class PrikazTakmicara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazTakmicara));
            this.takmicariListView = new System.Windows.Forms.ListView();
            this.jmbColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.klubColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pojasColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumRodjenjaColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pretragaTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pretraziBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.klubComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.takmicenjeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.datumComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.kategorijaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.grupisiPoComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.dodajBtn = new System.Windows.Forms.ToolStripButton();
            this.izbrisiBtn = new System.Windows.Forms.ToolStripButton();
            this.prikaziBtn = new System.Windows.Forms.ToolStripButton();
            this.prijaviBtn = new System.Windows.Forms.ToolStripButton();
            this.odjaviBtn = new System.Windows.Forms.ToolStripButton();
            this.osvjeziBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // takmicariListView
            // 
            resources.ApplyResources(this.takmicariListView, "takmicariListView");
            this.takmicariListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jmbColHead,
            this.imeColHead,
            this.prezimeColHead,
            this.klubColHead,
            this.pojasColHead,
            this.datumRodjenjaColHead});
            this.takmicariListView.FullRowSelect = true;
            this.takmicariListView.MultiSelect = false;
            this.takmicariListView.Name = "takmicariListView";
            this.takmicariListView.UseCompatibleStateImageBehavior = false;
            this.takmicariListView.View = System.Windows.Forms.View.Details;
            // 
            // jmbColHead
            // 
            resources.ApplyResources(this.jmbColHead, "jmbColHead");
            // 
            // imeColHead
            // 
            resources.ApplyResources(this.imeColHead, "imeColHead");
            // 
            // prezimeColHead
            // 
            resources.ApplyResources(this.prezimeColHead, "prezimeColHead");
            // 
            // klubColHead
            // 
            resources.ApplyResources(this.klubColHead, "klubColHead");
            // 
            // pojasColHead
            // 
            resources.ApplyResources(this.pojasColHead, "pojasColHead");
            // 
            // datumRodjenjaColHead
            // 
            resources.ApplyResources(this.datumRodjenjaColHead, "datumRodjenjaColHead");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.pretragaTextBox,
            this.pretraziBtn});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // pretragaTextBox
            // 
            this.pretragaTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("pretragaTextBox.AutoCompleteCustomSource"),
            resources.GetString("pretragaTextBox.AutoCompleteCustomSource1")});
            this.pretragaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pretragaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pretragaTextBox.Name = "pretragaTextBox";
            resources.ApplyResources(this.pretragaTextBox, "pretragaTextBox");
            this.pretragaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pretragaTextBox_KeyUp);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pretraziBtn.Image = global::KarateSavez.Properties.Resources.search;
            resources.ApplyResources(this.pretraziBtn, "pretraziBtn");
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.klubComboBox});
            resources.ApplyResources(this.toolStrip3, "toolStrip3");
            this.toolStrip3.Name = "toolStrip3";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            resources.ApplyResources(this.toolStripLabel5, "toolStripLabel5");
            // 
            // klubComboBox
            // 
            this.klubComboBox.AutoToolTip = true;
            this.klubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klubComboBox.Items.AddRange(new object[] {
            resources.GetString("klubComboBox.Items")});
            this.klubComboBox.Name = "klubComboBox";
            resources.ApplyResources(this.klubComboBox, "klubComboBox");
            this.klubComboBox.SelectedIndexChanged += new System.EventHandler(this.klubComboBox_SelectedIndexChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.takmicenjeComboBox,
            this.toolStripLabel3,
            this.datumComboBox,
            this.toolStripLabel4,
            this.kategorijaComboBox});
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // takmicenjeComboBox
            // 
            this.takmicenjeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.takmicenjeComboBox.Items.AddRange(new object[] {
            resources.GetString("takmicenjeComboBox.Items")});
            this.takmicenjeComboBox.Name = "takmicenjeComboBox";
            resources.ApplyResources(this.takmicenjeComboBox, "takmicenjeComboBox");
            this.takmicenjeComboBox.SelectedIndexChanged += new System.EventHandler(this.takmicenjeComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            // 
            // datumComboBox
            // 
            this.datumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datumComboBox.Name = "datumComboBox";
            resources.ApplyResources(this.datumComboBox, "datumComboBox");
            this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            resources.ApplyResources(this.toolStripLabel4, "toolStripLabel4");
            // 
            // kategorijaComboBox
            // 
            this.kategorijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategorijaComboBox.Name = "kategorijaComboBox";
            resources.ApplyResources(this.kategorijaComboBox, "kategorijaComboBox");
            this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.grupisiPoComboBox});
            resources.ApplyResources(this.toolStrip4, "toolStrip4");
            this.toolStrip4.Name = "toolStrip4";
            // 
            // toolStripLabel6
            // 
            resources.ApplyResources(this.toolStripLabel6, "toolStripLabel6");
            this.toolStripLabel6.Name = "toolStripLabel6";
            // 
            // grupisiPoComboBox
            // 
            this.grupisiPoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.grupisiPoComboBox, "grupisiPoComboBox");
            this.grupisiPoComboBox.Items.AddRange(new object[] {
            resources.GetString("grupisiPoComboBox.Items"),
            resources.GetString("grupisiPoComboBox.Items1"),
            resources.GetString("grupisiPoComboBox.Items2")});
            this.grupisiPoComboBox.Name = "grupisiPoComboBox";
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajBtn,
            this.izbrisiBtn,
            this.prikaziBtn,
            this.prijaviBtn,
            this.odjaviBtn,
            this.osvjeziBtn});
            resources.ApplyResources(this.toolStrip5, "toolStrip5");
            this.toolStrip5.Name = "toolStrip5";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Image = global::KarateSavez.Properties.Resources.new1;
            resources.ApplyResources(this.dodajBtn, "dodajBtn");
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Image = global::KarateSavez.Properties.Resources.brisi;
            resources.ApplyResources(this.izbrisiBtn, "izbrisiBtn");
            this.izbrisiBtn.Name = "izbrisiBtn";
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Image = global::KarateSavez.Properties.Resources.prikaz;
            resources.ApplyResources(this.prikaziBtn, "prikaziBtn");
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Click += new System.EventHandler(this.prikaziBtn_Click);
            // 
            // prijaviBtn
            // 
            this.prijaviBtn.Image = global::KarateSavez.Properties.Resources.prijava;
            resources.ApplyResources(this.prijaviBtn, "prijaviBtn");
            this.prijaviBtn.Name = "prijaviBtn";
            this.prijaviBtn.Click += new System.EventHandler(this.prijaviBtn_Click);
            // 
            // odjaviBtn
            // 
            this.odjaviBtn.Image = global::KarateSavez.Properties.Resources.odjava;
            resources.ApplyResources(this.odjaviBtn, "odjaviBtn");
            this.odjaviBtn.Name = "odjaviBtn";
            this.odjaviBtn.Click += new System.EventHandler(this.odjaviBtn_Click);
            // 
            // osvjeziBtn
            // 
            this.osvjeziBtn.Image = global::KarateSavez.Properties.Resources.reload;
            resources.ApplyResources(this.osvjeziBtn, "osvjeziBtn");
            this.osvjeziBtn.Name = "osvjeziBtn";
            this.osvjeziBtn.Click += new System.EventHandler(this.osvjeziBtn_Click);
            // 
            // PrikazTakmicara
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.takmicariListView);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "PrikazTakmicara";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView takmicariListView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox pretragaTextBox;
        private System.Windows.Forms.ToolStripButton pretraziBtn;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox klubComboBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox takmicenjeComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox datumComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox kategorijaComboBox;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox grupisiPoComboBox;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton dodajBtn;
        private System.Windows.Forms.ToolStripButton izbrisiBtn;
        private System.Windows.Forms.ToolStripButton prikaziBtn;
        private System.Windows.Forms.ToolStripButton osvjeziBtn;
        private System.Windows.Forms.ToolStripButton prijaviBtn;
        private System.Windows.Forms.ColumnHeader jmbColHead;
        private System.Windows.Forms.ColumnHeader imeColHead;
        private System.Windows.Forms.ColumnHeader prezimeColHead;
        private System.Windows.Forms.ColumnHeader klubColHead;
        private System.Windows.Forms.ColumnHeader pojasColHead;
        private System.Windows.Forms.ColumnHeader datumRodjenjaColHead;
        private System.Windows.Forms.ToolStripButton odjaviBtn;
    }
}