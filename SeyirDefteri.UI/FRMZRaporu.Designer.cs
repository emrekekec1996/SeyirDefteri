namespace SeyirDefteri.UI
{
    partial class FRMZRaporu
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
            lstVZRaporu = new ListView();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            lblBaslangic = new Label();
            lblBitis = new Label();
            btnPDFOlustur = new Button();
            btnMailAt = new Button();
            SuspendLayout();
            // 
            // lstVZRaporu
            // 
            lstVZRaporu.BackColor = Color.LightYellow;
            lstVZRaporu.Location = new Point(14, 93);
            lstVZRaporu.Margin = new Padding(3, 4, 3, 4);
            lstVZRaporu.Name = "lstVZRaporu";
            lstVZRaporu.Size = new Size(886, 489);
            lstVZRaporu.TabIndex = 0;
            lstVZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(184, 17);
            dtpBaslangic.Margin = new Padding(3, 4, 3, 4);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(228, 27);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(184, 52);
            dtpBitis.Margin = new Padding(3, 4, 3, 4);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(228, 27);
            dtpBitis.TabIndex = 2;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(14, 24);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(164, 20);
            lblBaslangic.TabIndex = 3;
            lblBaslangic.Text = "Başlangıç Tarihi Seçiniz:";
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(14, 59);
            lblBitis.Name = "lblBitis";
            lblBitis.Size = new Size(129, 20);
            lblBitis.TabIndex = 4;
            lblBitis.Text = "Bitiş Tarihi Seçiniz:";
            // 
            // btnPDFOlustur
            // 
            btnPDFOlustur.BackColor = Color.LightGreen;
            btnPDFOlustur.Location = new Point(14, 592);
            btnPDFOlustur.Margin = new Padding(3, 4, 3, 4);
            btnPDFOlustur.Name = "btnPDFOlustur";
            btnPDFOlustur.Size = new Size(171, 53);
            btnPDFOlustur.TabIndex = 5;
            btnPDFOlustur.Text = "PDF Oluştur";
            btnPDFOlustur.UseVisualStyleBackColor = false;
            btnPDFOlustur.Click += btnPDFOlustur_Click;
            // 
            // btnMailAt
            // 
            btnMailAt.BackColor = Color.LightBlue;
            btnMailAt.Location = new Point(729, 592);
            btnMailAt.Margin = new Padding(3, 4, 3, 4);
            btnMailAt.Name = "btnMailAt";
            btnMailAt.Size = new Size(171, 53);
            btnMailAt.TabIndex = 6;
            btnMailAt.Text = "Mail At";
            btnMailAt.UseVisualStyleBackColor = false;
            btnMailAt.Click += btnMailAt_Click;
            // 
            // FRMZRaporu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(900, 643);
            Controls.Add(btnMailAt);
            Controls.Add(btnPDFOlustur);
            Controls.Add(lblBitis);
            Controls.Add(lblBaslangic);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lstVZRaporu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FRMZRaporu";
            Text = "Z Raporu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lstVZRaporu;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Button btnPDFOlustur;
        private System.Windows.Forms.Button btnMailAt;
    }
}

