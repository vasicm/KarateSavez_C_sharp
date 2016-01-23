namespace KarateSavez
{
    partial class EditovanjeBorbe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.crveniComboBox = new System.Windows.Forms.ComboBox();
            this.plaviComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kategorijaComboBox = new System.Windows.Forms.ComboBox();
            this.takmicenjeComboBox = new System.Windows.Forms.ComboBox();
            this.poeniPlaviNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.poeniCrveniNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kaznePlaviNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kazneCrveniNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.krugNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.datumComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poeniPlaviNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniCrveniNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaznePlaviNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazneCrveniNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krugNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sacuvajBtn);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подаци о борби";
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sacuvajBtn.Location = new System.Drawing.Point(401, 507);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBtn.TabIndex = 2;
            this.sacuvajBtn.Text = "Сачувај";
            this.sacuvajBtn.UseVisualStyleBackColor = true;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.45232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.54768F));
            this.tableLayoutPanel1.Controls.Add(this.crveniComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.plaviComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kategorijaComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.takmicenjeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.poeniPlaviNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.poeniCrveniNumericUpDown, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.kaznePlaviNumericUpDown, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.kazneCrveniNumericUpDown, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.krugNumericUpDown, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.datumComboBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // crveniComboBox
            // 
            this.crveniComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crveniComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crveniComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crveniComboBox.FormattingEnabled = true;
            this.crveniComboBox.Location = new System.Drawing.Point(167, 196);
            this.crveniComboBox.Name = "crveniComboBox";
            this.crveniComboBox.Size = new System.Drawing.Size(295, 21);
            this.crveniComboBox.TabIndex = 32;
            // 
            // plaviComboBox
            // 
            this.plaviComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plaviComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plaviComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plaviComboBox.FormattingEnabled = true;
            this.plaviComboBox.Location = new System.Drawing.Point(167, 150);
            this.plaviComboBox.Name = "plaviComboBox";
            this.plaviComboBox.Size = new System.Drawing.Size(295, 21);
            this.plaviComboBox.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 51);
            this.label16.TabIndex = 30;
            this.label16.Text = "Круг такмичења:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 46);
            this.label14.TabIndex = 28;
            this.label14.Text = "Казне црвени:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 46);
            this.label12.TabIndex = 26;
            this.label12.Text = "Казне плави:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 46);
            this.label10.TabIndex = 24;
            this.label10.Text = "Поени црвени:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 46);
            this.label8.TabIndex = 22;
            this.label8.Text = "Поени плави:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 46);
            this.label6.TabIndex = 20;
            this.label6.Text = "Црвени:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "Плави:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Категорија:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Датум такмичења:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назив такмичења:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kategorijaComboBox
            // 
            this.kategorijaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kategorijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategorijaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kategorijaComboBox.FormattingEnabled = true;
            this.kategorijaComboBox.Location = new System.Drawing.Point(167, 104);
            this.kategorijaComboBox.Name = "kategorijaComboBox";
            this.kategorijaComboBox.Size = new System.Drawing.Size(295, 21);
            this.kategorijaComboBox.TabIndex = 16;
            this.kategorijaComboBox.SelectedIndexChanged += new System.EventHandler(this.kategorijaComboBox_SelectedIndexChanged);
            // 
            // takmicenjeComboBox
            // 
            this.takmicenjeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.takmicenjeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.takmicenjeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takmicenjeComboBox.FormattingEnabled = true;
            this.takmicenjeComboBox.Location = new System.Drawing.Point(167, 12);
            this.takmicenjeComboBox.Name = "takmicenjeComboBox";
            this.takmicenjeComboBox.Size = new System.Drawing.Size(295, 21);
            this.takmicenjeComboBox.TabIndex = 17;
            this.takmicenjeComboBox.SelectedIndexChanged += new System.EventHandler(this.takmicenjeComboBox_SelectedIndexChanged);
            // 
            // poeniPlaviNumericUpDown
            // 
            this.poeniPlaviNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.poeniPlaviNumericUpDown.Location = new System.Drawing.Point(167, 243);
            this.poeniPlaviNumericUpDown.Name = "poeniPlaviNumericUpDown";
            this.poeniPlaviNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.poeniPlaviNumericUpDown.TabIndex = 33;
            // 
            // poeniCrveniNumericUpDown
            // 
            this.poeniCrveniNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.poeniCrveniNumericUpDown.Location = new System.Drawing.Point(167, 289);
            this.poeniCrveniNumericUpDown.Name = "poeniCrveniNumericUpDown";
            this.poeniCrveniNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.poeniCrveniNumericUpDown.TabIndex = 34;
            // 
            // kaznePlaviNumericUpDown
            // 
            this.kaznePlaviNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kaznePlaviNumericUpDown.Location = new System.Drawing.Point(167, 335);
            this.kaznePlaviNumericUpDown.Name = "kaznePlaviNumericUpDown";
            this.kaznePlaviNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.kaznePlaviNumericUpDown.TabIndex = 35;
            // 
            // kazneCrveniNumericUpDown
            // 
            this.kazneCrveniNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kazneCrveniNumericUpDown.Location = new System.Drawing.Point(167, 381);
            this.kazneCrveniNumericUpDown.Name = "kazneCrveniNumericUpDown";
            this.kazneCrveniNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.kazneCrveniNumericUpDown.TabIndex = 36;
            // 
            // krugNumericUpDown
            // 
            this.krugNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.krugNumericUpDown.Location = new System.Drawing.Point(167, 429);
            this.krugNumericUpDown.Name = "krugNumericUpDown";
            this.krugNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.krugNumericUpDown.TabIndex = 37;
            // 
            // datumComboBox
            // 
            this.datumComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.datumComboBox.FormattingEnabled = true;
            this.datumComboBox.Location = new System.Drawing.Point(167, 58);
            this.datumComboBox.Name = "datumComboBox";
            this.datumComboBox.Size = new System.Drawing.Size(295, 21);
            this.datumComboBox.TabIndex = 38;
            this.datumComboBox.SelectedIndexChanged += new System.EventHandler(this.datumComboBox_SelectedIndexChanged);
            // 
            // EditovanjeBorbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 542);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditovanjeBorbe";
            this.Text = "EditovanjeBorbe";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poeniPlaviNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniCrveniNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaznePlaviNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazneCrveniNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krugNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kategorijaComboBox;
        private System.Windows.Forms.ComboBox takmicenjeComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox crveniComboBox;
        private System.Windows.Forms.ComboBox plaviComboBox;
        private System.Windows.Forms.NumericUpDown poeniPlaviNumericUpDown;
        private System.Windows.Forms.NumericUpDown poeniCrveniNumericUpDown;
        private System.Windows.Forms.NumericUpDown kaznePlaviNumericUpDown;
        private System.Windows.Forms.NumericUpDown kazneCrveniNumericUpDown;
        private System.Windows.Forms.NumericUpDown krugNumericUpDown;
        private System.Windows.Forms.ComboBox datumComboBox;
    }
}