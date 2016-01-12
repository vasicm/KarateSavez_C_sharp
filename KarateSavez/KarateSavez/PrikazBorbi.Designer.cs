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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Први круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Други круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Трећи круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Марко Васић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "4:2", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Милан Јанковић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.redinBrojColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plaviColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezultatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crveniColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.pomocBtn = new System.Windows.Forms.Button();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.redinBrojColHead,
            this.plaviColHead,
            this.rezultatColHead,
            this.crveniColHead});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup7.Header = "Први круг";
            listViewGroup7.Name = "prviKrugListVG";
            listViewGroup8.Header = "Други круг";
            listViewGroup8.Name = "drugiKrugListVG";
            listViewGroup9.Header = "Трећи круг";
            listViewGroup9.Name = "treciKrugListVG";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            listViewItem3.Group = listViewGroup7;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 268);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // redinBrojColHead
            // 
            this.redinBrojColHead.Text = "Редни број борбе";
            this.redinBrojColHead.Width = 148;
            // 
            // plaviColHead
            // 
            this.plaviColHead.Text = "Плави";
            this.plaviColHead.Width = 206;
            // 
            // rezultatColHead
            // 
            this.rezultatColHead.Text = "Резултат";
            this.rezultatColHead.Width = 167;
            // 
            // crveniColHead
            // 
            this.crveniColHead.Text = "Црвени";
            this.crveniColHead.Width = 147;
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zatvoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zatvoriBtn.Location = new System.Drawing.Point(677, 327);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 3;
            this.zatvoriBtn.Text = "Затвори";
            this.zatvoriBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // pomocBtn
            // 
            this.pomocBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pomocBtn.Location = new System.Drawing.Point(596, 327);
            this.pomocBtn.Name = "pomocBtn";
            this.pomocBtn.Size = new System.Drawing.Size(75, 23);
            this.pomocBtn.TabIndex = 4;
            this.pomocBtn.Text = "Помоћ";
            this.pomocBtn.UseVisualStyleBackColor = true;
            this.pomocBtn.Click += new System.EventHandler(this.pomocBtn_Click);
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
            // PrikazBorbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 373);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pomocBtn);
            this.Controls.Add(this.zatvoriBtn);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.Button pomocBtn;
        private System.Windows.Forms.ColumnHeader plaviColHead;
        private System.Windows.Forms.ColumnHeader rezultatColHead;
        private System.Windows.Forms.ColumnHeader crveniColHead;
        private System.Windows.Forms.ColumnHeader redinBrojColHead;
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