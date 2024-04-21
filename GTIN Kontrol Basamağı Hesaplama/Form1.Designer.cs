namespace GTIN_Kontrol_Basamağı_Hesaplama
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPartialGTIN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKontrolBasamagi = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGeneratedGTIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.listBoxKontrolBasamagi = new System.Windows.Forms.ListBox();
            this.listBoxTicariNumara = new System.Windows.Forms.ListBox();
            this.listBoxGTINs = new System.Windows.Forms.ListBox();
            this.btnCokluUret = new System.Windows.Forms.Button();
            this.txtKacAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMetin = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.chkAutoGenerate = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartialGTIN
            // 
            this.txtPartialGTIN.Location = new System.Drawing.Point(6, 21);
            this.txtPartialGTIN.Name = "txtPartialGTIN";
            this.txtPartialGTIN.Size = new System.Drawing.Size(239, 23);
            this.txtPartialGTIN.TabIndex = 1;
            this.txtPartialGTIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartialGTIN_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAutoGenerate);
            this.groupBox3.Controls.Add(this.txtPartialGTIN);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 53);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticari Ürün Numarası";
            // 
            // txtKontrolBasamagi
            // 
            this.txtKontrolBasamagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKontrolBasamagi.Location = new System.Drawing.Point(341, 23);
            this.txtKontrolBasamagi.Name = "txtKontrolBasamagi";
            this.txtKontrolBasamagi.ReadOnly = true;
            this.txtKontrolBasamagi.Size = new System.Drawing.Size(25, 20);
            this.txtKontrolBasamagi.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtGeneratedGTIN);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtKontrolBasamagi);
            this.groupBox5.Location = new System.Drawing.Point(6, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 51);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ticari Ürün Numarası (GTIN)";
            // 
            // txtGeneratedGTIN
            // 
            this.txtGeneratedGTIN.Location = new System.Drawing.Point(6, 21);
            this.txtGeneratedGTIN.Name = "txtGeneratedGTIN";
            this.txtGeneratedGTIN.Size = new System.Drawing.Size(239, 23);
            this.txtGeneratedGTIN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kontrol Basamağı";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(289, 138);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(86, 30);
            this.btnUret.TabIndex = 4;
            this.btnUret.Text = "Oluştur";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // listBoxKontrolBasamagi
            // 
            this.listBoxKontrolBasamagi.FormattingEnabled = true;
            this.listBoxKontrolBasamagi.ItemHeight = 16;
            this.listBoxKontrolBasamagi.Location = new System.Drawing.Point(131, 22);
            this.listBoxKontrolBasamagi.Name = "listBoxKontrolBasamagi";
            this.listBoxKontrolBasamagi.Size = new System.Drawing.Size(42, 132);
            this.listBoxKontrolBasamagi.TabIndex = 13;
            this.listBoxKontrolBasamagi.SelectedIndexChanged += new System.EventHandler(this.listBoxKontrolBasamagi_SelectedIndexChanged);
            // 
            // listBoxTicariNumara
            // 
            this.listBoxTicariNumara.FormattingEnabled = true;
            this.listBoxTicariNumara.ItemHeight = 16;
            this.listBoxTicariNumara.Location = new System.Drawing.Point(5, 22);
            this.listBoxTicariNumara.Name = "listBoxTicariNumara";
            this.listBoxTicariNumara.Size = new System.Drawing.Size(120, 132);
            this.listBoxTicariNumara.TabIndex = 14;
            this.listBoxTicariNumara.SelectedIndexChanged += new System.EventHandler(this.listBoxTicariNumara_SelectedIndexChanged);
            // 
            // listBoxGTINs
            // 
            this.listBoxGTINs.FormattingEnabled = true;
            this.listBoxGTINs.ItemHeight = 16;
            this.listBoxGTINs.Location = new System.Drawing.Point(179, 22);
            this.listBoxGTINs.Name = "listBoxGTINs";
            this.listBoxGTINs.Size = new System.Drawing.Size(120, 132);
            this.listBoxGTINs.TabIndex = 15;
            this.listBoxGTINs.SelectedIndexChanged += new System.EventHandler(this.listBoxGTINs_SelectedIndexChanged);
            // 
            // btnCokluUret
            // 
            this.btnCokluUret.Location = new System.Drawing.Point(149, 22);
            this.btnCokluUret.Name = "btnCokluUret";
            this.btnCokluUret.Size = new System.Drawing.Size(83, 30);
            this.btnCokluUret.TabIndex = 6;
            this.btnCokluUret.Text = "Çoklu Üret";
            this.btnCokluUret.UseVisualStyleBackColor = true;
            this.btnCokluUret.Click += new System.EventHandler(this.btnCokluUret_Click);
            // 
            // txtKacAdet
            // 
            this.txtKacAdet.Location = new System.Drawing.Point(108, 26);
            this.txtKacAdet.Name = "txtKacAdet";
            this.txtKacAdet.Size = new System.Drawing.Size(35, 23);
            this.txtKacAdet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adet Miktarı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 177);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekli Oluştur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKacAdet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCokluUret);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 62);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çoklu Oluştur";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMetin);
            this.groupBox4.Controls.Add(this.btnExcel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(272, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 62);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çıktı Seçenekleri";
            // 
            // btnMetin
            // 
            this.btnMetin.Location = new System.Drawing.Point(59, 21);
            this.btnMetin.Name = "btnMetin";
            this.btnMetin.Size = new System.Drawing.Size(47, 30);
            this.btnMetin.TabIndex = 8;
            this.btnMetin.Text = "Metin";
            this.btnMetin.UseVisualStyleBackColor = true;
            this.btnMetin.Click += new System.EventHandler(this.btnMetin_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(6, 21);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(47, 30);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxGTINs);
            this.groupBox6.Controls.Add(this.listBoxKontrolBasamagi);
            this.groupBox6.Controls.Add(this.listBoxTicariNumara);
            this.groupBox6.Location = new System.Drawing.Point(45, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 163);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Oluşturulan GTIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GTIN_Kontrol_Basamağı_Hesaplama.Properties.Resources._1690998329chatgpt_logo_with_text;
            this.pictureBox1.Location = new System.Drawing.Point(121, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Düzenleme: Sefa Dönmez";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(291, 438);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(67, 30);
            this.buttonTemizle.TabIndex = 9;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // chkAutoGenerate
            // 
            this.chkAutoGenerate.AutoSize = true;
            this.chkAutoGenerate.Location = new System.Drawing.Point(249, 22);
            this.chkAutoGenerate.Name = "chkAutoGenerate";
            this.chkAutoGenerate.Size = new System.Drawing.Size(114, 21);
            this.chkAutoGenerate.TabIndex = 2;
            this.chkAutoGenerate.Text = "Otomatik Üret";
            this.chkAutoGenerate.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 515);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 554);
            this.MinimumSize = new System.Drawing.Size(419, 554);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTIN-13 (12 Basamak) v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPartialGTIN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKontrolBasamagi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGeneratedGTIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.ListBox listBoxKontrolBasamagi;
        private System.Windows.Forms.ListBox listBoxTicariNumara;
        private System.Windows.Forms.ListBox listBoxGTINs;
        private System.Windows.Forms.Button btnCokluUret;
        private System.Windows.Forms.TextBox txtKacAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMetin;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.CheckBox chkAutoGenerate;
    }
}

