namespace KarateSavez
{
    partial class PrikazBorbi
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Први круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Други круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Трећи круг", System.Windows.Forms.HorizontalAlignment.Left);
            this.borbeListView = new System.Windows.Forms.ListView();
            this.plaviColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezultatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crveniColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.takmicenjeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.datumComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.kategorijaComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.dodajBtn = new System.Windows.Forms.ToolStripButton();
            this.izbrisiBtn = new System.Windows.Forms.ToolStripButton();
            this.prikaziBtn = new System.Windows.Forms.ToolStripButton();
            this.osvjeziBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // borbeListView
            // 
            this.borbeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borbeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.plaviColHead,
            this.rezultatColHead,
            this.crveniColHead});
            this.borbeListView.FullRowSelect = true;
            listViewGroup4.Header = "Први круг";
            listViewGroup4.Name = "prviKrugListVG";
            listViewGroup5.Header = "Други круг";
            listViewGroup5.Name = "drugiKrugListVG";
            listViewGroup6.Header = "Трећи круг";
            listViewGroup6.Name = "treciKrugListVG";
            this.borbeListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.borbeListView.Location = new System.Drawing.Point(0, 50);
            this.borbeListView.Name = "borbeListView";
            this.borbeListView.Size = new System.Drawing.Size(764, 323);
            this.borbeListView.TabIndex = 2;
            this.borbeListView.UseCompatibleStateImageBehavior = false;
            this.borbeListView.View = System.Windows.Forms.View.Details;
            // 
            // plaviColHead
            // 
            this.plaviColHead.Text = "Плави";
            this.plaviColHead.Width = 271;
            // 
            // rezultatColHead
            // 
            this.rezultatColHead.Text = "Резултат";
            this.rezultatColHead.Width = 118;
            // 
            // crveniColHead
            // 
            this.crveniColHead.Text = "Црвени";
            this.crveniColHead.Width = 279;
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(764, 25);
            this.toolStrip2.TabIndex = 22;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "Такмичење:";
            // 
            // takmicenjeComboBox
            // 
            this.takmicenjeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.takmicenjeComboBox.Name = "takmicenjeComboBox";
            this.takmicenjeComboBox.Size = new System.Drawing.Size(121, 25);
            this.takmicenjeComboBox.SelectedIndexChanged += new System.EventHandler(this.takmicenjeComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "Датум:";
            // 
            // datumComboBox
            // 
            this.datumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datumComboBox.Name = "datumComboBox";
            this.datumComboBox.Size = new System.Drawing.Size(121, 25);
            this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel4.Text = "Категорија:";
            // 
            // kategorijaComboBox
            // 
            this.kategorijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategorijaComboBox.Name = "kategorijaComboBox";
            this.kategorijaComboBox.Size = new System.Drawing.Size(121, 25);
            this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);
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
            this.toolStrip5.Size = new System.Drawing.Size(764, 25);
            this.toolStrip5.TabIndex = 24;
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
            this.izbrisiBtn.Image = global::KarateSavez.Properties.Resources.brisi;
            this.izbrisiBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(66, 22);
            this.izbrisiBtn.Text = "Бриши";
            this.izbrisiBtn.Click += new System.EventHandler(this.izbrisiBtn_Click);
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Image = global::KarateSavez.Properties.Resources.prikaz;
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
            // PrikazBorbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 373);
            this.Controls.Add(this.borbeListView);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip2);
            this.Name = "PrikazBorbi";
            this.Text = "Такмичења";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView borbeListView;
        private System.Windows.Forms.ColumnHeader plaviColHead;
        private System.Windows.Forms.ColumnHeader rezultatColHead;
        private System.Windows.Forms.ColumnHeader crveniColHead;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox takmicenjeComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox datumComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox kategorijaComboBox;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton dodajBtn;
        private System.Windows.Forms.ToolStripButton izbrisiBtn;
        private System.Windows.Forms.ToolStripButton prikaziBtn;
        private System.Windows.Forms.ToolStripButton osvjeziBtn;
    }
}