using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SeyirDefteri.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class FRMZRaporu : Form
    {
        private List<Gonderim> Gonderimler;
        public FRMZRaporu()
        {
            InitializeComponent();
        }
        public FRMZRaporu(List<Gonderim> gonderimler) : this()
        {
            Gonderimler = gonderimler;
            ListViewKolonEkle();
            ListeyiGuncelle();
        }
        private void ListViewKolonEkle()
        {
            //list view görünümü detaylı moda ayalıyorum 
            lstVZRaporu.View = View.Details;
            lstVZRaporu.GridLines = true;
            //list viewin başlıklarını ekliyoruz
            lstVZRaporu.Columns.Add("Gemi Adi", 150);
            lstVZRaporu.Columns.Add("Limandan Çıkış Tarihi", 150);
            lstVZRaporu.Columns.Add("Limana Varış Tarihi", 150);
            lstVZRaporu.Columns.Add("Urun Adi", 150);
            lstVZRaporu.Columns.Add("Firma Adi", 150);
            lstVZRaporu.Columns.Add("Ürün Yükü", 150);
            lstVZRaporu.Columns.Add("Kalan Tonaj", 150);

        }

        private void ListeyiGuncelle()
        {
            //dtp ile olan değeri aldım 
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date;

            //where -> benin dtp içindeki zaman aralığım ile seferlerimin zaman aralığının uyuşması lazım onun için burada where sorgusu yazdık
            //groupby -> gemilerimi kendi içn grupladım (her seferdeki seçilen gemi sdaece kendi içinde gruplandı yani titnica 5 ürün taşıyorsa sadece titanik olarka alındı eklenen diğer gemiler de yalnızca kendi içlerinde gruplandı)
            //bunları birer listehye dönüştürdüm -> tolist -> burada gruplana yani 5 tane ayni gemiye ürün varsa herbirini listeledik 
            var gemiBazliGonderimler = Gonderimler
                .Where(g => g.SeyirKaydi.LimandanCikisTarihi.Date >= baslangicTarihi &&
                g.SeyirKaydi.LimanaVarisTarihi.Date <= bitisTarihi)
                .GroupBy(g => g.SeyirKaydi.Gemi.GemiAdi)
                .ToList();

                lstVZRaporu.Items.Clear();
            foreach (var grup in gemiBazliGonderimler)
            {
                //yukarıda listelediğimiz gemileri kendi içindede göndeirm oalrak ayrıştırdık

                //ilk itemi al demek 
                decimal gemiTonji = grup.First().SeyirKaydi.Gemi?.Tonaji ?? 0;

                decimal toplamKullanilanTonaj = 0;
                foreach (Gonderim gonderim in grup)
                {
                    //burada kalan tonajı hesapladık
                    toplamKullanilanTonaj += gonderim.Tonaj;
                    decimal kalanTonaj = gemiTonji - toplamKullanilanTonaj;

                    ListViewItem listViewItem = new ListViewItem();
                    //listview ıtemin  subıtemlarına  istenilen değeri ekledık
                    listViewItem.Text = gonderim.SeyirKaydi.Gemi.GemiAdi;
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimandanCikisTarihi.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimanaVarisTarihi.ToString("dd/MMM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.Urun.UrunAdi);
                    listViewItem.SubItems.Add(gonderim.IlgilenenKisi.BagliOlduguFirma.FirmaAdi);
                    listViewItem.SubItems.Add(gonderim.Tonaj.ToString());

                    if (kalanTonaj >= 0)
                    {
                        listViewItem.SubItems.Add(kalanTonaj.ToString());
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Gemi battı!!!!");

                    }
                    lstVZRaporu.Items.Add(listViewItem);

                }
            }
        }
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void btnPDFOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                //i text sharp
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF Dosyası Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document();
                    //pdf doyasının beliritilen dosya yolunda oluşmasını sağlıyorum 
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();//belgeyi açıyoruz

                    //pdf içinde kullanıklıcak tabloyu oluşturuyorum bu tabloya içine ekleyeceğim sütun sayısı kadar sürun eklıyorum 
                    PdfPTable table = new PdfPTable(lstVZRaporu.Columns.Count);
                    table.WidthPercentage = 100;

                    //listviewimbaşlıklarını pdf olarak ekliyorum
                    foreach (ColumnHeader column in lstVZRaporu.Columns)
                    {
                        //başlık cellerine (hücrelerine) başlık metinin eklıyiruım
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(column.Text));
                        pdfPCell.BackgroundColor = BaseColor.LIGHT_GRAY;//hücrenin arka planına griyi verdim
                        table.AddCell(pdfPCell);//başlıkarımı hücrelerine cellerine ekledim
                    }

                    foreach (ListViewItem item in lstVZRaporu.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                        {
                            table.AddCell(subitem.Text);//tablomun hücreliene subitemalrımı ekledim 
                        }
                    }
                    document.Add(table);

                    document.Close();
                    MessageBox.Show("PDF başaryıla oluşmaktadır !!!!");

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMailAt_Click(object sender, EventArgs e)
        {
            try
            {
                string excelDosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"GönderimZraporu.xlsx");
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Gönderim ZRaporu");

                    for (int col = 0; col < lstVZRaporu.Columns.Count; col++)
                    {

                        worksheet.Cell(1, col + 1).Value = lstVZRaporu.Columns[col].Text;
                    }
                    int row = 2;
                    foreach (ListViewItem item in lstVZRaporu.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            worksheet.Cell(row, i + 1).Value = item.SubItems[i].Text;
                        }
                        row++;
                        
                    }
                    workbook.SaveAs(excelDosyaYolu);
                }
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress("gönderen kişinni mail adresi");
                mailMessage.To.Add("gönderidğim kişi kime gönderiyorum");
                mailMessage.Subject = "Gönderimin Z Raporu";
                mailMessage.Body = "Merhaba İyi çalışmalar, \nEkteki Dosya göndeirmin z raporudur";

                mailMessage.Attachments.Add(new Attachment(excelDosyaYolu));

                smtpClient.Port = 587;
                
                smtpClient.Credentials = new NetworkCredential("gönderen mailim ile","bu mailin uygulama şifresi");

                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);

                MessageBox.Show("Eposta göndeirldi !!!!");


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
