namespace SeyirDefteri.UI
{
    partial class FRMGonderim
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
            btnUrunEkle = new Button();
            lstVGonderim = new ListView();
            lblUrun = new Label();
            nmcTonj = new NumericUpDown();
            cmbFirma = new ComboBox();
            mtxtTelefon = new MaskedTextBox();
            txtIlgilenenKisi = new TextBox();
            lblSeferler = new Label();
            cmbSeferler = new ComboBox();
            txtUrun = new TextBox();
            lblTonaj = new Label();
            lblIlgilenenKisi = new Label();
            lblFirma = new Label();
            lblIlgilenenKisiTelefonu = new Label();
            btnGec = new Button();
            ((System.ComponentModel.ISupportInitialize)nmcTonj).BeginInit();
            SuspendLayout();
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.LightGreen;
            btnUrunEkle.Location = new Point(445, 319);
            btnUrunEkle.Margin = new Padding(3, 4, 3, 4);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(114, 40);
            btnUrunEkle.TabIndex = 0;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // lstVGonderim
            // 
            lstVGonderim.BackColor = Color.LightYellow;
            lstVGonderim.Location = new Point(24, 367);
            lstVGonderim.Margin = new Padding(3, 4, 3, 4);
            lstVGonderim.Name = "lstVGonderim";
            lstVGonderim.Size = new Size(548, 199);
            lstVGonderim.TabIndex = 1;
            lstVGonderim.UseCompatibleStateImageBehavior = false;
            // 
            // lblUrun
            // 
            lblUrun.AutoSize = true;
            lblUrun.Location = new Point(23, 87);
            lblUrun.Name = "lblUrun";
            lblUrun.Size = new Size(40, 20);
            lblUrun.TabIndex = 2;
            lblUrun.Text = "Ürün";
            // 
            // nmcTonj
            // 
            nmcTonj.Location = new Point(183, 133);
            nmcTonj.Margin = new Padding(3, 4, 3, 4);
            nmcTonj.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            nmcTonj.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            nmcTonj.Name = "nmcTonj";
            nmcTonj.Size = new Size(229, 27);
            nmcTonj.TabIndex = 3;
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(183, 187);
            cmbFirma.Margin = new Padding(3, 4, 3, 4);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(228, 28);
            cmbFirma.TabIndex = 4;
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(183, 293);
            mtxtTelefon.Margin = new Padding(3, 4, 3, 4);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(228, 27);
            mtxtTelefon.TabIndex = 5;
            // 
            // txtIlgilenenKisi
            // 
            txtIlgilenenKisi.Location = new Point(183, 240);
            txtIlgilenenKisi.Margin = new Padding(3, 4, 3, 4);
            txtIlgilenenKisi.Name = "txtIlgilenenKisi";
            txtIlgilenenKisi.Size = new Size(228, 27);
            txtIlgilenenKisi.TabIndex = 6;
            // 
            // lblSeferler
            // 
            lblSeferler.AutoSize = true;
            lblSeferler.Location = new Point(23, 35);
            lblSeferler.Name = "lblSeferler";
            lblSeferler.Size = new Size(60, 20);
            lblSeferler.TabIndex = 2;
            lblSeferler.Text = "Seferler";
            // 
            // cmbSeferler
            // 
            cmbSeferler.FormattingEnabled = true;
            cmbSeferler.Location = new Point(184, 27);
            cmbSeferler.Margin = new Padding(3, 4, 3, 4);
            cmbSeferler.Name = "cmbSeferler";
            cmbSeferler.Size = new Size(228, 28);
            cmbSeferler.TabIndex = 4;
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(184, 80);
            txtUrun.Margin = new Padding(3, 4, 3, 4);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(228, 27);
            txtUrun.TabIndex = 6;
            // 
            // lblTonaj
            // 
            lblTonaj.AutoSize = true;
            lblTonaj.Location = new Point(23, 140);
            lblTonaj.Name = "lblTonaj";
            lblTonaj.Size = new Size(45, 20);
            lblTonaj.TabIndex = 2;
            lblTonaj.Text = "Tonaj";
            // 
            // lblIlgilenenKisi
            // 
            lblIlgilenenKisi.AutoSize = true;
            lblIlgilenenKisi.Location = new Point(23, 247);
            lblIlgilenenKisi.Name = "lblIlgilenenKisi";
            lblIlgilenenKisi.Size = new Size(93, 20);
            lblIlgilenenKisi.TabIndex = 2;
            lblIlgilenenKisi.Text = "İlgilenen Kişi";
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(23, 195);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(46, 20);
            lblFirma.TabIndex = 2;
            lblFirma.Text = "Firma";
            // 
            // lblIlgilenenKisiTelefonu
            // 
            lblIlgilenenKisiTelefonu.AutoSize = true;
            lblIlgilenenKisiTelefonu.Location = new Point(23, 300);
            lblIlgilenenKisiTelefonu.Name = "lblIlgilenenKisiTelefonu";
            lblIlgilenenKisiTelefonu.Size = new Size(154, 20);
            lblIlgilenenKisiTelefonu.TabIndex = 2;
            lblIlgilenenKisiTelefonu.Text = "İlgilenen Kişi Telefonu";
            // 
            // btnGec
            // 
            btnGec.BackColor = Color.LightBlue;
            btnGec.Location = new Point(24, 574);
            btnGec.Margin = new Padding(3, 4, 3, 4);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(549, 40);
            btnGec.TabIndex = 0;
            btnGec.Text = "Diğer Sayfaya Geç";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // FRMGonderim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(571, 612);
            Controls.Add(txtUrun);
            Controls.Add(txtIlgilenenKisi);
            Controls.Add(mtxtTelefon);
            Controls.Add(cmbSeferler);
            Controls.Add(cmbFirma);
            Controls.Add(nmcTonj);
            Controls.Add(lblSeferler);
            Controls.Add(lblIlgilenenKisiTelefonu);
            Controls.Add(lblFirma);
            Controls.Add(lblIlgilenenKisi);
            Controls.Add(lblTonaj);
            Controls.Add(lblUrun);
            Controls.Add(lstVGonderim);
            Controls.Add(btnGec);
            Controls.Add(btnUrunEkle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMGonderim";
            Text = "Gönderim Ekranı";
            Load += FRMGonderim_Load;
            ((System.ComponentModel.ISupportInitialize)nmcTonj).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListView lstVGonderim;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.NumericUpDown nmcTonj;
        private System.Windows.Forms.ComboBox cmbFirma;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.TextBox txtIlgilenenKisi;
        private System.Windows.Forms.Label lblSeferler;
        private System.Windows.Forms.ComboBox cmbSeferler;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label lblTonaj;
        private System.Windows.Forms.Label lblIlgilenenKisi;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblIlgilenenKisiTelefonu;
        private System.Windows.Forms.Button btnGec;
    }
}
