using SeyirDefteri.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class FRMGonderim : Form
    {
        public FRMGonderim()
        {
            InitializeComponent();
        }
        public FRMGonderim(List<SeyirKaydi> seyirKayitlari) : this()
        {
            foreach (SeyirKaydi seyirKaydi in seyirKayitlari)
            {

                cmbSeferler.Items.Add(seyirKaydi);

            }
        }
        private void ListVieweSutunEkle()
        {
            lstVGonderim.View = View.Details;
            lstVGonderim.GridLines = true;

            lstVGonderim.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lstVGonderim.Columns.Add("Tonaj ", 100, HorizontalAlignment.Center);
            lstVGonderim.Columns.Add("Ürün ", 100, HorizontalAlignment.Center);
            lstVGonderim.Columns.Add("Firma ", 150, HorizontalAlignment.Center);
            lstVGonderim.Columns.Add("Kişi Adı", 150, HorizontalAlignment.Center);
            lstVGonderim.Columns.Add("İletişim", 150, HorizontalAlignment.Center);

        }
        private void FirmalariOlustur()
        {
            List<Firma> firmalar = new List<Firma>()
     {new Firma{FirmaId=1, FirmaAdi="Amazon"},
     new Firma{FirmaId=2, FirmaAdi="Etsy"},
     new Firma{FirmaId=3, FirmaAdi="Ebay"},
     new Firma{FirmaId=4, FirmaAdi="Wish"},
     new Firma{FirmaId=5, FirmaAdi="Alibaba"},
     new Firma{FirmaId=6, FirmaAdi="Banggood"},
     new Firma{FirmaId=7, FirmaAdi="n11"},
     new Firma{FirmaId=8, FirmaAdi="Trendyol"},
     new Firma{FirmaId=9, FirmaAdi="ÇiçekSepeti"},
     new Firma{FirmaId=10, FirmaAdi="Bonanza"},
     new Firma{FirmaId=11, FirmaAdi="ModCloth"},
     new Firma{FirmaId=12, FirmaAdi="Wayfair"},
     new Firma{FirmaId=13, FirmaAdi="Runway"},
     new Firma{FirmaId=14, FirmaAdi="Shein"},
     new Firma{FirmaId=15, FirmaAdi="Farfetch"},
     new Firma{FirmaId=16, FirmaAdi="Macy's"},
     new Firma{FirmaId=17, FirmaAdi="LightInTheBox"},
     new Firma{FirmaId=18, FirmaAdi="Shein"},
     new Firma{FirmaId=19, FirmaAdi="ASOS"},
     new Firma{FirmaId=20, FirmaAdi="Zalando"},


     };
            foreach (var item in firmalar)
            {
                cmbFirma.Items.Add(item);
            }
        }

        private void Temizle()
        {
            cmbFirma.SelectedItem = null;
            cmbSeferler.SelectedItem = null;

            txtIlgilenenKisi.Text = txtUrun.Text = mtxtTelefon.Text = string.Empty;

            nmcTonj.Value = 0;

        }

        private void FRMGonderim_Load(object sender, EventArgs e)
        {
            FirmalariOlustur();
            ListVieweSutunEkle();
        }

        int id = 0;
        int urunId = 1;
        int ilgilenenKisiId = 0;
        private Gemi seciliGemi;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {


            if (cmbSeferler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer seçin!!!");
                return;
            }
            if (cmbFirma.SelectedItem == null)
            {
                MessageBox.Show("Lütfen firma seçin!!!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrun.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz");
                return;
            }

            SeyirKaydi seciliSeyir = cmbSeferler.SelectedItem as SeyirKaydi;

            seciliGemi = seciliSeyir.Gemi;

            if (nmcTonj.Value < 0 || seciliGemi.Tonaji < nmcTonj.Value)
            {
                MessageBox.Show("Geminin tonajı büyük bir değrer giremez");
                return;
            }

            Gonderim gonderim = new Gonderim();
            gonderim.SeyirKaydi = cmbSeferler.SelectedItem as SeyirKaydi;

            gonderim.Urun = new Urun();
            gonderim.Urun.UrunId = urunId++;
            gonderim.Urun.UrunAdi = txtUrun.Text;

            gonderim.Tonaj = nmcTonj.Value;

            gonderim.IlgilenenKisi = new IlgilenenKisi();
            gonderim.IlgilenenKisi.KisininAdi = txtIlgilenenKisi.Text;
            gonderim.IlgilenenKisi.KisininTelefonu = mtxtTelefon.Text;
            gonderim.IlgilenenKisi.IlgilenenKisiId = ilgilenenKisiId++;
            gonderim.IlgilenenKisi.BagliOlduguFirma = cmbFirma.SelectedItem as Firma;


            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = (++id).ToString();
            listViewItem.SubItems.Add(gonderim.Tonaj.ToString());
            listViewItem.SubItems.Add(gonderim.Urun.UrunAdi);
            listViewItem.SubItems.Add(gonderim.IlgilenenKisi.BagliOlduguFirma.FirmaAdi);
            listViewItem.SubItems.Add(gonderim.IlgilenenKisi.KisininAdi);
            listViewItem.SubItems.Add(gonderim.IlgilenenKisi.KisininTelefonu);

            //todo 
            //burada her bir list itemımın tag kontrolune göndeirm nesenesini gizledim
            listViewItem.Tag = gonderim;
            //burada list itemlarımı listview içersine ekleme yaptım
            lstVGonderim.Items.Add(listViewItem);
            Temizle();


        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (lstVGonderim.Items.Count>0)
            {
                //bir gönderim listesi oluşturdum
                List<Gonderim> gonderimler = new List<Gonderim>();
            //burada daha önce eklediğim list itemlarımı listview içinde dönerek her list itemin tagine ulaştım orada göndeirm nesnesi vardı bende bunlar bir göndeirm listesine ekledim
                foreach (ListViewItem item in lstVGonderim.Items)
                {
                    gonderimler.Add((Gonderim)item.Tag);
                }


                //foreach (Gonderim item in lstVGonderim.Items)
                //{
                //   gonderimler.Add(item);
                //}


                //eklediğim göndeirm lşistesini form 3te çağırdım
                FRMZRaporu fRMZRaporu = new FRMZRaporu(gonderimler);
                fRMZRaporu.Show();
            }
        }
    }
}
