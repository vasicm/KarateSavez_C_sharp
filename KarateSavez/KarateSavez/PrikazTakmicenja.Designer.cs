namespace KarateSavez
{
    partial class PrikazTakmicenja
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
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Први круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Други круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Трећи круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Марко Васић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "4:2", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Милан Јанковић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pretraziTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pretraziBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.dodajBtn = new System.Windows.Forms.ToolStripButton();
            this.izbrisiBtn = new System.Windows.Forms.ToolStripButton();
            this.prikaziBtn = new System.Windows.Forms.ToolStripButton();
            this.osvjeziBtn = new System.Windows.Forms.ToolStripButton();
            this.takmicenjaListView = new System.Windows.Forms.ListView();
            this.nazivColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.organizatorColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresaColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.toolStrip1.Size = new System.Drawing.Size(680, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.toolStrip5.Size = new System.Drawing.Size(680, 25);
            this.toolStrip5.TabIndex = 25;
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
            // takmicenjaListView
            // 
            this.takmicenjaListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takmicenjaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nazivColHead,
            this.datumColHead,
            this.organizatorColHead,
            this.adresaColHead});
            listViewGroup13.Header = "Први круг";
            listViewGroup13.Name = "prviKrugListVG";
            listViewGroup14.Header = "Други круг";
            listViewGroup14.Name = "drugiKrugListVG";
            listViewGroup15.Header = "Трећи круг";
            listViewGroup15.Name = "treciKrugListVG";
            this.takmicenjaListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            listViewItem5.Group = listViewGroup13;
            this.takmicenjaListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.takmicenjaListView.Location = new System.Drawing.Point(0, 49);
            this.takmicenjaListView.Name = "takmicenjaListView";
            this.takmicenjaListView.Size = new System.Drawing.Size(680, 339);
            this.takmicenjaListView.TabIndex = 26;
            this.takmicenjaListView.UseCompatibleStateImageBehavior = false;
            this.takmicenjaListView.View = System.Windows.Forms.View.Details;
            // 
            // nazivColHead
            // 
            this.nazivColHead.Text = "Назив такмичења";
            this.nazivColHead.Width = 148;
            // 
            // datumColHead
            // 
            this.datumColHead.Text = "Датум почетка";
            this.datumColHead.Width = 206;
            // 
            // organizatorColHead
            // 
            this.organizatorColHead.Text = "Организатор";
            this.organizatorColHead.Width = 167;
            // 
            // adresaColHead
            // 
            this.adresaColHead.Text = "Адреса";
            this.adresaColHead.Width = 147;
            // 
            // PrikazTakmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 388);
            this.Controls.Add(this.takmicenjaListView);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrikazTakmicenja";
            this.Text = "PrikazTakmicenja";
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
        private System.Windows.Forms.ListView takmicenjaListView;
        private System.Windows.Forms.ColumnHeader nazivColHead;
        private System.Windows.Forms.ColumnHeader datumColHead;
        private System.Windows.Forms.ColumnHeader organizatorColHead;
        private System.Windows.Forms.ColumnHeader adresaColHead;
    }
}