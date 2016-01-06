namespace KarateSavez
{
    partial class EditovanjeTakmicara
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
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.imeTxtBox = new System.Windows.Forms.TextBox();
            this.prezimeTxtBox = new System.Windows.Forms.TextBox();
            this.jmbTxtBox = new System.Windows.Forms.TextBox();
            this.datumRodjenjadTPicker = new System.Windows.Forms.DateTimePicker();
            this.klubComboBox = new System.Windows.Forms.ComboBox();
            this.pojasComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sacuvajBtn);
            this.groupBox1.Controls.Add(this.zatvoriBtn);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подаци о такмичару";
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(328, 332);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 23);
            this.zatvoriBtn.TabIndex = 1;
            this.zatvoriBtn.Text = "Затвори";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.izmijeniBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.45232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.54768F));
            this.tableLayoutPanel1.Controls.Add(this.pojasComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.jmbTxtBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.prezimeTxtBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imeTxtBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.datumRodjenjadTPicker, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.klubComboBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 50);
            this.label11.TabIndex = 11;
            this.label11.Text = "Датум рођења:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 50);
            this.label9.TabIndex = 9;
            this.label9.Text = "Појас:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "Клуб:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "ЈМБ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Презиме:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.Location = new System.Drawing.Point(247, 332);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.sacuvajBtn.TabIndex = 2;
            this.sacuvajBtn.Text = "Сачувај";
            this.sacuvajBtn.UseVisualStyleBackColor = true;
            // 
            // imeTxtBox
            // 
            this.imeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imeTxtBox.Location = new System.Drawing.Point(148, 15);
            this.imeTxtBox.Name = "imeTxtBox";
            this.imeTxtBox.Size = new System.Drawing.Size(258, 20);
            this.imeTxtBox.TabIndex = 13;
            // 
            // prezimeTxtBox
            // 
            this.prezimeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prezimeTxtBox.Location = new System.Drawing.Point(148, 65);
            this.prezimeTxtBox.Name = "prezimeTxtBox";
            this.prezimeTxtBox.Size = new System.Drawing.Size(258, 20);
            this.prezimeTxtBox.TabIndex = 14;
            // 
            // jmbTxtBox
            // 
            this.jmbTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jmbTxtBox.Location = new System.Drawing.Point(148, 115);
            this.jmbTxtBox.Name = "jmbTxtBox";
            this.jmbTxtBox.Size = new System.Drawing.Size(258, 20);
            this.jmbTxtBox.TabIndex = 15;
            // 
            // datumRodjenjadTPicker
            // 
            this.datumRodjenjadTPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datumRodjenjadTPicker.Location = new System.Drawing.Point(148, 265);
            this.datumRodjenjadTPicker.Name = "datumRodjenjadTPicker";
            this.datumRodjenjadTPicker.Size = new System.Drawing.Size(258, 20);
            this.datumRodjenjadTPicker.TabIndex = 16;
            // 
            // klubComboBox
            // 
            this.klubComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.klubComboBox.FormattingEnabled = true;
            this.klubComboBox.Location = new System.Drawing.Point(148, 164);
            this.klubComboBox.Name = "klubComboBox";
            this.klubComboBox.Size = new System.Drawing.Size(258, 21);
            this.klubComboBox.TabIndex = 17;
            // 
            // pojasComboBox
            // 
            this.pojasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pojasComboBox.FormattingEnabled = true;
            this.pojasComboBox.Location = new System.Drawing.Point(148, 214);
            this.pojasComboBox.Name = "pojasComboBox";
            this.pojasComboBox.Size = new System.Drawing.Size(258, 21);
            this.pojasComboBox.TabIndex = 18;
            // 
            // EditovanjeTakmicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 368);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditovanjeTakmicara";
            this.Text = "EditovanjeTakmicara";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.ComboBox pojasComboBox;
        private System.Windows.Forms.TextBox jmbTxtBox;
        private System.Windows.Forms.TextBox prezimeTxtBox;
        private System.Windows.Forms.TextBox imeTxtBox;
        private System.Windows.Forms.DateTimePicker datumRodjenjadTPicker;
        private System.Windows.Forms.ComboBox klubComboBox;
    }
}