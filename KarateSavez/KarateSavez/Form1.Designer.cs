namespace KarateSavez
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Такмичење", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Друге активности", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Испит", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Куп Републике Српске",
            "Карате клуб ИПОН Прњавор организује куп Републике Српске који ће се одржати 22.3." +
                "2016. године у градској дворани.",
            "10.01.2016"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Првенстов Републике Српске",
            "Карате клуб Слога Добој организује куп Републике Српске који ће се одржати 16.4.2" +
                "016. године у градској дворани.",
            "11.01.2016."}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Љетни камп",
            "Карате клуб Леотар из требиња организује љетни спортски камп, који ће се одршати " +
                "у требињу и трајаће од 10.08.1016. до 20.08.2016.",
            "15.01.2016."}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.vrijemeObjaveColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naslovColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tekstOglasaColHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pocetnaStripBtn = new System.Windows.Forms.ToolStripButton();
            this.takmicenjaStripBtn = new System.Windows.Forms.ToolStripButton();
            this.pregletStripBtn = new System.Windows.Forms.ToolStripButton();
            this.podesavanjaStripBtn = new System.Windows.Forms.ToolStripButton();
            this.новиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.огласToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.такмичарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.такмичењеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помоћToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оКаратеСавезуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упутстоЗаКоришћењеАпликацијеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подешавањаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатнаПодешавањаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затвориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.прегледToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.такмичењаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.такмичењаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.подешавањаToolStripMenuItem,
            this.помоћToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новиToolStripMenuItem,
            this.прегледToolStripMenuItem,
            this.toolStripSeparator1,
            this.затвориToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "Фајл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocetnaStripBtn,
            this.takmicenjaStripBtn,
            this.pregletStripBtn,
            this.podesavanjaStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(421, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naslovColHead,
            this.tekstOglasaColHead,
            this.vrijemeObjaveColHead});
            listViewGroup4.Header = "Такмичење";
            listViewGroup4.Name = "takmicenjeListVG";
            listViewGroup5.Header = "Друге активности";
            listViewGroup5.Name = "drugeAktivnostiListVG";
            listViewGroup6.Header = "Испит";
            listViewGroup6.Name = "ispitListVG";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            listViewItem4.Group = listViewGroup4;
            listViewItem5.Group = listViewGroup4;
            listViewItem6.Group = listViewGroup5;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(0, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(892, 441);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // vrijemeObjaveColHead
            // 
            this.vrijemeObjaveColHead.Text = "Вријеме објаве";
            this.vrijemeObjaveColHead.Width = 250;
            // 
            // naslovColHead
            // 
            this.naslovColHead.Text = "Наслов огласа";
            this.naslovColHead.Width = 222;
            // 
            // tekstOglasaColHead
            // 
            this.tekstOglasaColHead.Text = "Текст огласа";
            this.tekstOglasaColHead.Width = 363;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(206, 17);
            this.toolStripStatusLabel2.Text = "Аутор: Марко Васић ЕТФБЛ  1113/11";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pocetnaStripBtn
            // 
            this.pocetnaStripBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pocetnaStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("pocetnaStripBtn.Image")));
            this.pocetnaStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pocetnaStripBtn.Name = "pocetnaStripBtn";
            this.pocetnaStripBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pocetnaStripBtn.Size = new System.Drawing.Size(83, 23);
            this.pocetnaStripBtn.Text = "Почетна";
            // 
            // takmicenjaStripBtn
            // 
            this.takmicenjaStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("takmicenjaStripBtn.Image")));
            this.takmicenjaStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.takmicenjaStripBtn.Name = "takmicenjaStripBtn";
            this.takmicenjaStripBtn.Size = new System.Drawing.Size(91, 23);
            this.takmicenjaStripBtn.Text = "Такмичења";
            this.takmicenjaStripBtn.ToolTipText = "Такмичења";
            // 
            // pregletStripBtn
            // 
            this.pregletStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("pregletStripBtn.Image")));
            this.pregletStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pregletStripBtn.Name = "pregletStripBtn";
            this.pregletStripBtn.Size = new System.Drawing.Size(135, 23);
            this.pregletStripBtn.Text = "Преглед такмичара";
            // 
            // podesavanjaStripBtn
            // 
            this.podesavanjaStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("podesavanjaStripBtn.Image")));
            this.podesavanjaStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.podesavanjaStripBtn.Name = "podesavanjaStripBtn";
            this.podesavanjaStripBtn.Size = new System.Drawing.Size(100, 23);
            this.podesavanjaStripBtn.Text = "Подешавања";
            // 
            // новиToolStripMenuItem
            // 
            this.новиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.огласToolStripMenuItem,
            this.такмичарToolStripMenuItem,
            this.такмичењеToolStripMenuItem});
            this.новиToolStripMenuItem.Name = "новиToolStripMenuItem";
            this.новиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.новиToolStripMenuItem.Text = "Нови...";
            // 
            // огласToolStripMenuItem
            // 
            this.огласToolStripMenuItem.Name = "огласToolStripMenuItem";
            this.огласToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.огласToolStripMenuItem.Text = "Оглас";
            // 
            // такмичарToolStripMenuItem
            // 
            this.такмичарToolStripMenuItem.Name = "такмичарToolStripMenuItem";
            this.такмичарToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.такмичарToolStripMenuItem.Text = "Такмичар";
            // 
            // такмичењеToolStripMenuItem
            // 
            this.такмичењеToolStripMenuItem.Name = "такмичењеToolStripMenuItem";
            this.такмичењеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.такмичењеToolStripMenuItem.Text = "Такмичење";
            // 
            // помоћToolStripMenuItem
            // 
            this.помоћToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограмуToolStripMenuItem,
            this.оКаратеСавезуToolStripMenuItem,
            this.упутстоЗаКоришћењеАпликацијеToolStripMenuItem});
            this.помоћToolStripMenuItem.Name = "помоћToolStripMenuItem";
            this.помоћToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.помоћToolStripMenuItem.Text = "Помоћ";
            // 
            // оПрограмуToolStripMenuItem
            // 
            this.оПрограмуToolStripMenuItem.Name = "оПрограмуToolStripMenuItem";
            this.оПрограмуToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.оПрограмуToolStripMenuItem.Text = "О апликацији";
            this.оПрограмуToolStripMenuItem.Click += new System.EventHandler(this.оПрограмуToolStripMenuItem_Click);
            // 
            // оКаратеСавезуToolStripMenuItem
            // 
            this.оКаратеСавезуToolStripMenuItem.Name = "оКаратеСавезуToolStripMenuItem";
            this.оКаратеСавезуToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.оКаратеСавезуToolStripMenuItem.Text = "О карате савезу";
            // 
            // упутстоЗаКоришћењеАпликацијеToolStripMenuItem
            // 
            this.упутстоЗаКоришћењеАпликацијеToolStripMenuItem.Name = "упутстоЗаКоришћењеАпликацијеToolStripMenuItem";
            this.упутстоЗаКоришћењеАпликацијеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.упутстоЗаКоришћењеАпликацијеToolStripMenuItem.Text = "Упутсто за коришћење апликације";
            // 
            // подешавањаToolStripMenuItem
            // 
            this.подешавањаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem,
            this.додатнаПодешавањаToolStripMenuItem});
            this.подешавањаToolStripMenuItem.Name = "подешавањаToolStripMenuItem";
            this.подешавањаToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.подешавањаToolStripMenuItem.Text = "Подешавања";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // додатнаПодешавањаToolStripMenuItem
            // 
            this.додатнаПодешавањаToolStripMenuItem.Name = "додатнаПодешавањаToolStripMenuItem";
            this.додатнаПодешавањаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.додатнаПодешавањаToolStripMenuItem.Text = "Додатна подешавања";
            // 
            // затвориToolStripMenuItem
            // 
            this.затвориToolStripMenuItem.Name = "затвориToolStripMenuItem";
            this.затвориToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.затвориToolStripMenuItem.Text = "Затвори...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // прегледToolStripMenuItem
            // 
            this.прегледToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.такмичењаToolStripMenuItem,
            this.такмичењаToolStripMenuItem1});
            this.прегледToolStripMenuItem.Name = "прегледToolStripMenuItem";
            this.прегледToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.прегледToolStripMenuItem.Text = "Преглед";
            // 
            // такмичењаToolStripMenuItem
            // 
            this.такмичењаToolStripMenuItem.Name = "такмичењаToolStripMenuItem";
            this.такмичењаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.такмичењаToolStripMenuItem.Text = "Такмичара";
            this.такмичењаToolStripMenuItem.Click += new System.EventHandler(this.такмичењаToolStripMenuItem_Click);
            // 
            // такмичењаToolStripMenuItem1
            // 
            this.такмичењаToolStripMenuItem1.Name = "такмичењаToolStripMenuItem1";
            this.такмичењаToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.такмичењаToolStripMenuItem1.Text = "Такмичења";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 519);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Карате Савез Републике Српске";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pocetnaStripBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton takmicenjaStripBtn;
        private System.Windows.Forms.ToolStripButton pregletStripBtn;
        private System.Windows.Forms.ToolStripButton podesavanjaStripBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader vrijemeObjaveColHead;
        private System.Windows.Forms.ColumnHeader naslovColHead;
        private System.Windows.Forms.ColumnHeader tekstOglasaColHead;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem новиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem огласToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem такмичарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem такмичењеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помоћToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оКаратеСавезуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упутстоЗаКоришћењеАпликацијеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прегледToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem такмичењаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem затвориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подешавањаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатнаПодешавањаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem такмичењаToolStripMenuItem1;
    }
}

