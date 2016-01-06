namespace KarateSavez
{
    partial class Takmicenja
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Први круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Други круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Трећи круг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Марко Васић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "4:2", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Милан Јанковић", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Takmicenja));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.izbrisiBtn = new System.Windows.Forms.Button();
            this.prikaziBtn = new System.Windows.Forms.Button();
            this.plaviColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezultatColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crveniColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.redinBrojColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripLabel2,
            this.toolStripComboBox2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Такмичење:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Куп РС",
            "Првенство РС",
            "Ђурђевдански куп"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel2.Text = "Категорија:";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "јуниори лака",
            "јуниори средња",
            "јуниори тешка"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.redinBrojColHead,
            this.plaviColHead,
            this.rezultatColHead,
            this.crveniColHead});
            listViewGroup1.Header = "Први круг";
            listViewGroup1.Name = "prviKrugListVG";
            listViewGroup2.Header = "Други круг";
            listViewGroup2.Name = "drugiKrugListVG";
            listViewGroup3.Header = "Трећи круг";
            listViewGroup3.Name = "treciKrugListVG";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 308);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dodajBtn
            // 
            this.dodajBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajBtn.Location = new System.Drawing.Point(677, 342);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 3;
            this.dodajBtn.Text = "Додај ";
            this.dodajBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajBtn.UseVisualStyleBackColor = true;
            // 
            // izbrisiBtn
            // 
            this.izbrisiBtn.Location = new System.Drawing.Point(596, 342);
            this.izbrisiBtn.Name = "izbrisiBtn";
            this.izbrisiBtn.Size = new System.Drawing.Size(75, 23);
            this.izbrisiBtn.TabIndex = 4;
            this.izbrisiBtn.Text = "Избриши";
            this.izbrisiBtn.UseVisualStyleBackColor = true;
            // 
            // prikaziBtn
            // 
            this.prikaziBtn.Location = new System.Drawing.Point(515, 342);
            this.prikaziBtn.Name = "prikaziBtn";
            this.prikaziBtn.Size = new System.Drawing.Size(75, 23);
            this.prikaziBtn.TabIndex = 5;
            this.prikaziBtn.Text = "Прикажи";
            this.prikaziBtn.UseVisualStyleBackColor = true;
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
            // redinBrojColHead
            // 
            this.redinBrojColHead.Text = "Редни број борбе";
            this.redinBrojColHead.Width = 148;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Takmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 373);
            this.Controls.Add(this.prikaziBtn);
            this.Controls.Add(this.izbrisiBtn);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Takmicenja";
            this.Text = "Такмичења";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button izbrisiBtn;
        private System.Windows.Forms.Button prikaziBtn;
        private System.Windows.Forms.ColumnHeader plaviColHead;
        private System.Windows.Forms.ColumnHeader rezultatColHead;
        private System.Windows.Forms.ColumnHeader crveniColHead;
        private System.Windows.Forms.ColumnHeader redinBrojColHead;
    }
}