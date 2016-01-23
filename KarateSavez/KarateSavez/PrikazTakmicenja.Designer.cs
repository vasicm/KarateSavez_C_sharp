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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pretraziTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pretraziBtn = new System.Windows.Forms.ToolStripButton();
            this.dbgLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.dodajBtn = new System.Windows.Forms.ToolStripButton();
            this.izbrisiBtn = new System.Windows.Forms.ToolStripButton();
            this.prikaziBtn = new System.Windows.Forms.ToolStripButton();
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
            this.pretraziBtn,
            this.dbgLabel});
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
            this.pretraziTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pretraziTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pretraziTextBox.Name = "pretraziTextBox";
            this.pretraziTextBox.Size = new System.Drawing.Size(150, 25);
            this.pretraziTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pretraziTextBox_KeyUp);
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
            // dbgLabel
            // 
            this.dbgLabel.Name = "dbgLabel";
            this.dbgLabel.Size = new System.Drawing.Size(86, 22);
            this.dbgLabel.Text = "toolStripLabel2";
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajBtn,
            this.izbrisiBtn,
            this.prikaziBtn});
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
            this.takmicenjaListView.FullRowSelect = true;
            this.takmicenjaListView.Location = new System.Drawing.Point(0, 49);
            this.takmicenjaListView.MultiSelect = false;
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
        private System.Windows.Forms.ListView takmicenjaListView;
        private System.Windows.Forms.ColumnHeader nazivColHead;
        private System.Windows.Forms.ColumnHeader datumColHead;
        private System.Windows.Forms.ColumnHeader organizatorColHead;
        private System.Windows.Forms.ColumnHeader adresaColHead;
        private System.Windows.Forms.ToolStripLabel dbgLabel;
    }
}