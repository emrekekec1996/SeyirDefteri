namespace SeyirDefteri.UI
{
    partial class FRMSeyirEkrani
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dtpVarisTarihi = new DateTimePicker();
            lblLimandanCikisTarihi = new Label();
            cmbGemi = new ComboBox();
            btnSeferOlustur = new Button();
            lvSeferler = new ListView();
            cmbCikisLimani = new ComboBox();
            cmbUgradigiLimani = new ComboBox();
            cmbVarisLimani = new ComboBox();
            dtpCikisTarihi = new DateTimePicker();
            lblLimanaVarisTarihi = new Label();
            lblGemi = new Label();
            lblCikisLimani = new Label();
            lblUgradigiLiman = new Label();
            lblVarisLimani = new Label();
            btnGec = new Button();
            SuspendLayout();
            // 
            // dtpVarisTarihi
            // 
            dtpVarisTarihi.Location = new Point(165, 59);
            dtpVarisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpVarisTarihi.Name = "dtpVarisTarihi";
            dtpVarisTarihi.Size = new Size(228, 27);
            dtpVarisTarihi.TabIndex = 0;
            // 
            // lblLimandanCikisTarihi
            // 
            lblLimandanCikisTarihi.AutoSize = true;
            lblLimandanCikisTarihi.Location = new Point(12, 23);
            lblLimandanCikisTarihi.Name = "lblLimandanCikisTarihi";
            lblLimandanCikisTarihi.Size = new Size(147, 20);
            lblLimandanCikisTarihi.TabIndex = 1;
            lblLimandanCikisTarihi.Text = "Limandan Çıkış Tarihi";
            // 
            // cmbGemi
            // 
            cmbGemi.FormattingEnabled = true;
            cmbGemi.Location = new Point(165, 94);
            cmbGemi.Margin = new Padding(3, 4, 3, 4);
            cmbGemi.Name = "cmbGemi";
            cmbGemi.Size = new Size(228, 28);
            cmbGemi.TabIndex = 2;
            // 
            // btnSeferOlustur
            // 
            btnSeferOlustur.BackColor = Color.LightGreen;
            btnSeferOlustur.Location = new Point(408, 232);
            btnSeferOlustur.Margin = new Padding(3, 4, 3, 4);
            btnSeferOlustur.Name = "btnSeferOlustur";
            btnSeferOlustur.Size = new Size(155, 41);
            btnSeferOlustur.TabIndex = 3;
            btnSeferOlustur.Text = "Sefer Oluştur";
            btnSeferOlustur.UseVisualStyleBackColor = false;
            btnSeferOlustur.Click += btnSeferOlustur_Click;
            // 
            // lvSeferler
            // 
            lvSeferler.BackColor = Color.LightYellow;
            lvSeferler.Location = new Point(12, 281);
            lvSeferler.Margin = new Padding(3, 4, 3, 4);
            lvSeferler.Name = "lvSeferler";
            lvSeferler.Size = new Size(551, 356);
            lvSeferler.TabIndex = 4;
            lvSeferler.UseCompatibleStateImageBehavior = false;
            // 
            // cmbCikisLimani
            // 
            cmbCikisLimani.FormattingEnabled = true;
            cmbCikisLimani.Location = new Point(165, 130);
            cmbCikisLimani.Margin = new Padding(3, 4, 3, 4);
            cmbCikisLimani.Name = "cmbCikisLimani";
            cmbCikisLimani.Size = new Size(228, 28);
            cmbCikisLimani.TabIndex = 2;
            // 
            // cmbUgradigiLimani
            // 
            cmbUgradigiLimani.FormattingEnabled = true;
            cmbUgradigiLimani.Location = new Point(165, 166);
            cmbUgradigiLimani.Margin = new Padding(3, 4, 3, 4);
            cmbUgradigiLimani.Name = "cmbUgradigiLimani";
            cmbUgradigiLimani.Size = new Size(228, 28);
            cmbUgradigiLimani.TabIndex = 2;
            // 
            // cmbVarisLimani
            // 
            cmbVarisLimani.FormattingEnabled = true;
            cmbVarisLimani.Location = new Point(165, 202);
            cmbVarisLimani.Margin = new Padding(3, 4, 3, 4);
            cmbVarisLimani.Name = "cmbVarisLimani";
            cmbVarisLimani.Size = new Size(228, 28);
            cmbVarisLimani.TabIndex = 2;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(165, 18);
            dtpCikisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(228, 27);
            dtpCikisTarihi.TabIndex = 0;
            // 
            // lblLimanaVarisTarihi
            // 
            lblLimanaVarisTarihi.AutoSize = true;
            lblLimanaVarisTarihi.Location = new Point(12, 64);
            lblLimanaVarisTarihi.Name = "lblLimanaVarisTarihi";
            lblLimanaVarisTarihi.Size = new Size(131, 20);
            lblLimanaVarisTarihi.TabIndex = 1;
            lblLimanaVarisTarihi.Text = "Limana Varış Tarihi";
            // 
            // lblGemi
            // 
            lblGemi.AutoSize = true;
            lblGemi.Location = new Point(12, 102);
            lblGemi.Name = "lblGemi";
            lblGemi.Size = new Size(44, 20);
            lblGemi.TabIndex = 1;
            lblGemi.Text = "Gemi";
            // 
            // lblCikisLimani
            // 
            lblCikisLimani.AutoSize = true;
            lblCikisLimani.Location = new Point(12, 138);
            lblCikisLimani.Name = "lblCikisLimani";
            lblCikisLimani.Size = new Size(87, 20);
            lblCikisLimani.TabIndex = 1;
            lblCikisLimani.Text = "Çıkış Limanı";
            // 
            // lblUgradigiLiman
            // 
            lblUgradigiLiman.AutoSize = true;
            lblUgradigiLiman.Location = new Point(12, 174);
            lblUgradigiLiman.Name = "lblUgradigiLiman";
            lblUgradigiLiman.Size = new Size(111, 20);
            lblUgradigiLiman.TabIndex = 1;
            lblUgradigiLiman.Text = "Uğradığı Liman";
            // 
            // lblVarisLimani
            // 
            lblVarisLimani.AutoSize = true;
            lblVarisLimani.Location = new Point(12, 210);
            lblVarisLimani.Name = "lblVarisLimani";
            lblVarisLimani.Size = new Size(88, 20);
            lblVarisLimani.TabIndex = 1;
            lblVarisLimani.Text = "Varış Limanı";
            // 
            // btnGec
            // 
            btnGec.BackColor = Color.LightBlue;
            btnGec.Location = new Point(12, 645);
            btnGec.Margin = new Padding(3, 4, 3, 4);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(551, 47);
            btnGec.TabIndex = 5;
            btnGec.Text = "Diğer Sayfaya Geç";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // FRMSeyirEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(568, 691);
            Controls.Add(btnGec);
            Controls.Add(lvSeferler);
            Controls.Add(btnSeferOlustur);
            Controls.Add(cmbVarisLimani);
            Controls.Add(cmbUgradigiLimani);
            Controls.Add(cmbCikisLimani);
            Controls.Add(cmbGemi);
            Controls.Add(lblVarisLimani);
            Controls.Add(lblUgradigiLiman);
            Controls.Add(lblCikisLimani);
            Controls.Add(lblGemi);
            Controls.Add(lblLimanaVarisTarihi);
            Controls.Add(lblLimandanCikisTarihi);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(dtpVarisTarihi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMSeyirEkrani";
            Text = "Seyir Ekranı";
            Load += FRMSeyirEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVarisTarihi;
        private System.Windows.Forms.Label lblLimandanCikisTarihi;
        private System.Windows.Forms.ComboBox cmbGemi;
        private System.Windows.Forms.Button btnSeferOlustur;
        private System.Windows.Forms.ListView lvSeferler;
        private System.Windows.Forms.ComboBox cmbCikisLimani;
        private System.Windows.Forms.ComboBox cmbUgradigiLimani;
        private System.Windows.Forms.ComboBox cmbVarisLimani;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label lblLimanaVarisTarihi;
        private System.Windows.Forms.Label lblGemi;
        private System.Windows.Forms.Label lblCikisLimani;
        private System.Windows.Forms.Label lblUgradigiLiman;
        private System.Windows.Forms.Label lblVarisLimani;
        private System.Windows.Forms.Button btnGec;
    }
}

