using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyp_PaketServisv1._2
{
    public class Yazdir
    {
        public int IslemNo { get; set; }
        public Yazdir(int islemno)
        {
            IslemNo = islemno;
        }

        PrintDocument pd = new PrintDocument();
        OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailDal());
        CompanyManager companyManager = new CompanyManager(new EfCompanyDal());
        public void YazdirmayaBasla()
        {
            try
            {
                pd.PrintPage += Pd_PrintPage;
                //pd.Print()

                PrintPreviewDialog pDialog = new PrintPreviewDialog();
                pDialog.Document = pd; 
                pDialog.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            //MartketDbEntities db = new MartketDbEntities();
            var liste = orderDetailManager.GetOrderDetailOrProduct(IslemNo);
            var isyeri = companyManager.GetAll().FirstOrDefault();
            //var liste = db.Satis.Where(x => IslemNo == IslemNo).ToList();
            if (isyeri != null && liste != null)
            {
                int kagituzunluk = 120;
                for (int i = 0; i < liste.Count; i++)
                {
                    kagituzunluk += 15;

                }
                PaperSize ps58 = new PaperSize("58mm Termal", 20, kagituzunluk + 120);
                pd.DefaultPageSettings.PaperSize = ps58;


                Font fontBaslik = new Font("Calibri", 10, FontStyle.Bold);///UNVAN FONT
                Font fontBilgi = new Font("Calibri", 8, FontStyle.Bold);///BİLGİ FONT
                Font fontIcerikBaslik = new Font("Calibri", 8, FontStyle.Underline);///ÜRÜN FONT
                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                RectangleF rcUnvanKonum = new RectangleF(0, 20, 220, 20);
                e.Graphics.DrawString(isyeri.Title, fontBaslik, Brushes.Black, rcUnvanKonum, ortala);
                e.Graphics.DrawString("Telefon :" + isyeri.Phone, fontBilgi, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("İşlem No  :" + IslemNo.ToString(), fontBilgi, Brushes.Black, new Point(5, 60));
                e.Graphics.DrawString("Tarih  :" + DateTime.Now, fontBilgi, Brushes.Black, new Point(80, 60));
                //e.Graphics.DrawString("Vergi Numarası :" + isyeri.VergiNo, fontBilgi, Brushes.Black, new Point(5, 75));
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, 90));
                ///Üst Kısım Sabit
                e.Graphics.DrawString("Ürün Adı", fontIcerikBaslik, Brushes.Black, new Point(5, 105));
                e.Graphics.DrawString("Miktar", fontIcerikBaslik, Brushes.Black, new Point(100, 105));
                e.Graphics.DrawString("Fiyat", fontIcerikBaslik, Brushes.Black, new Point(140, 105));
                e.Graphics.DrawString("Tutar", fontIcerikBaslik, Brushes.Black, new Point(180, 105));
                ///Üst Kısım Sabit
                int yukseklik = 120;
                double geneltoplam = 0;
                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.ProductName, fontBilgi, Brushes.Black, new Point(5, yukseklik));
                    e.Graphics.DrawString(item.Quantity.ToString(), fontBilgi, Brushes.Black, new Point(100, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.UnitPrice).ToString("C2"), fontBilgi, Brushes.Black, new Point(140, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.UnitPrice * item.Quantity).ToString("C2"), fontBilgi, Brushes.Black, new Point(180, yukseklik));
                    yukseklik += 15;
                    geneltoplam += Convert.ToDouble(item.UnitPrice * item.Quantity);
                }
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, yukseklik));
                e.Graphics.DrawString("Toplam :" + geneltoplam.ToString("C2"), fontBaslik, Brushes.Black, new Point(5, yukseklik + 20));
                e.Graphics.DrawString("----------------------------------------------------------", fontBilgi, Brushes.Black, new Point(5, yukseklik + 40));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", fontBilgi, Brushes.Black, new Point(5, yukseklik + 60));

            }
        }
    }
}
