using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Eyp_PaketServisv1._2.CallerIdEntegre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyp_PaketServisv1._2
{
    public partial class FormSiparis : Form
    {
        CallerId caller;
        public FormSiparis()
        {
            InitializeComponent();
            caller = new CallerId(this);
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailDal());
        Order order;
        public int CustomerId;
        f_Ayarlar ayarlar = new f_Ayarlar();


        private void btnCustomerShow_Click(object sender, EventArgs e)
        {
            f_CustomerList f_CustomerList = new f_CustomerList();
            f_CustomerList.ShowDialog();
        }

        private void fSiparis_Load(object sender, EventArgs e)
        {

            var result = categoryManager.GetAll();

            List<Button> btn = new List<Button>() { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7 };

            for (int i = 0; i < result.Count; i++)
            {

                btn[i].Text = result[i].CategoryName.ToUpper();
                btn[i].Name = result[i].CategoryId.ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id:" + CustomerId.ToString());
        }
        public void ProductGetCategoryId(int categoryId)
        {
            var result = productManager.GetByIdList(categoryId);
            dataGridView1.DataSource = result;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn0.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn1.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn2.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn3.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn4.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn5.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn6.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn7.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                ProductGetCategoryId(Convert.ToInt32(btn8.Name));
            }
            catch
            {

                MessageBox.Show("Yeterli Sayıda Kategori Bulunamadı");
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var productId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var result = productManager.GetById(Convert.ToInt32(productId));

            //DataGridView dataGridView = new DataGridView();

            result.Stock = 1;
            var totalPrice = result.SalePrice * result.Stock;
            string[] row = { result.ProductId.ToString(), result.ProductName, result.Stock.ToString(), result.SalePrice.ToString(), totalPrice.ToString() };
            var a = new DataGridViewRow();

            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);

            //decimal toplam = 0;
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{

            //    toplam += Convert.ToDecimal(listView1.Items[i].SubItems[3].Text);

            //    lblTotalPrice.Text = toplam.ToString();


            //}





        }

        private void btnTableChoose_Click(object sender, EventArgs e)
        {
            f_Masalar masalar = new f_Masalar();
            masalar.ShowDialog();
        }
        //miktar arttırma
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                //listviewde tıklanan satırın indexini al
                var secilenSatirId = listView1.SelectedItems[0].Index;
                //o indexe göre değeri bul
                var secilenDeger = listView1.Items[secilenSatirId].SubItems[2].Text;
                //bulunan miktar değerini 1 arttır
                secilenDeger = (Convert.ToInt32(secilenDeger) + (int)1).ToString();
                //arttırılan değeri tekrar listviewe aktar
                listView1.Items[secilenSatirId].SubItems[2].Text = secilenDeger;
                //fiyat bilgisini al
                var fiyatBilgisi = listView1.Items[secilenSatirId].SubItems[3].Text;
                //yeni toplam fiyatı hesapla
                var toplamFiyat = Convert.ToDecimal(fiyatBilgisi) * Convert.ToInt32(secilenDeger);
                //yeni toplamı listview yaz
                listView1.Items[secilenSatirId].SubItems[4].Text = toplamFiyat.ToString();
            }
            catch
            {

                MessageBox.Show("Lütfen ürünü seçiniz");
            }




        }
        //miktar azaltma
        private void btnReduce_Click(object sender, EventArgs e)
        {
            try
            {
                var secilenSatirId = listView1.SelectedItems[0].Index;
                var secilenDeger = listView1.Items[secilenSatirId].SubItems[2].Text;
                if (Convert.ToInt32(secilenDeger) > 1)
                {
                    secilenDeger = (Convert.ToInt32(secilenDeger) - (int)1).ToString();
                    listView1.Items[secilenSatirId].SubItems[2].Text = secilenDeger;
                    var fiyatBilgisi = listView1.Items[secilenSatirId].SubItems[3].Text;
                    var toplamFiyat = Convert.ToDecimal(fiyatBilgisi) * Convert.ToInt32(secilenDeger);
                    listView1.Items[secilenSatirId].SubItems[4].Text = toplamFiyat.ToString();
                }
                else
                {
                    MessageBox.Show("Sipariş için en az 1 adet ürün olmalı");
                }
            }
            catch
            {

                MessageBox.Show("Lütfen ürünü seçiniz");
            }



        }
        //silme
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //int secilenSayi = listView1.SelectedItems.Count;
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                }
            }
            catch
            {

                MessageBox.Show("Lütfen Önce ürün ekleyiniz");
            }
        }

        private void orderAdd_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {

                toplam += Convert.ToDecimal(listView1.Items[i].SubItems[4].Text);
            }
            lblTotalPrice.Text = toplam.ToString();
            MessageBox.Show($"Toplam Tutar={lblTotalPrice.Text}");
            lblOdenen.Text = "000";
            lblKalan.Text = "000";
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            f_SiparisListesi siparis = new f_SiparisListesi();
            siparis.ShowDialog();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (lblKalan.Text!="000" && lblOdenen.Text!="000")
            {
                PaymentTransaction(1);
            }
            else
            {
                MessageBox.Show("Lütfen müşteriden alınan ödeme miktarını giriniz");
            }
           
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            PaymentTransaction(2);
        }

        private void PaymentTransaction(int paymentTypeId)
        {
            order = new Order();
            OrderDetail orderDetail = new OrderDetail();
            order.CustomerId = CustomerId;
            order.PaymentTypeId = paymentTypeId;
            order.OrderDate = DateTime.Now.Date;
            order.OrderDateHour = DateTime.Now.TimeOfDay.ToString();
            orderManager.Add(order);

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                var productId = listView1.Items[i].SubItems[0].Text;
                var unitPrice = listView1.Items[i].SubItems[3].Text;
                var quantity = listView1.Items[i].SubItems[2].Text;
                orderDetail.OrderId = order.OrderId;
                orderDetail.ProductId = Convert.ToInt32(productId);
                orderDetail.UnitPrice = Convert.ToDecimal(unitPrice);
                orderDetail.Quantity = Convert.ToInt32(quantity);
                orderDetailManager.Add(orderDetail);

            }

            //decimal toplam = 0;
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{

            //    toplam += Convert.ToDecimal(listView1.Items[i].SubItems[4].Text);
            //}
            //lblTotalPrice.Text = toplam.ToString();
            Yazdir yazdir = new Yazdir(order.OrderId);
            yazdir.YazdirmayaBasla();
            MessageBox.Show("Ödeme Gerçekleştirildi");
        }

        private void btnCreditCash_Click(object sender, EventArgs e)
        {
            PaymentTransaction(3);
        }
       
        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            PaymentTransaction(4);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                
                //int fisNo = 1;
                //Font font = new Font("Arial", 12);
                //SolidBrush brush = new SolidBrush(Color.Black);
                //e.Graphics.DrawString($"Fiş No:{fisNo}", font, brush, 60, 25);
                //e.Graphics.DrawString($"Tarih:{DateTime.Now}", font, brush, 300, 25);
                //e.Graphics.DrawString($"{ayarlar.lblCompanyName.Text}", font, brush, 180, 80);
                //e.Graphics.DrawString($"Paket Servis Hizmeti", font, brush, 180, 120);
                //e.Graphics.DrawString($"İletişim:{ayarlar.lblCompanyPhone.Text}", font, brush, 180, 160);
                //e.Graphics.DrawString($"Adres:{ayarlar.lblCompanyAddress.Text}", font, brush, 180, 200);
                //Pen pen = new Pen(brush, 10);
                // e.Graphics.DrawLine(pen, 180, 300,180,300);

                //comboBox1.DisplayMember = "PaperName";

                //PaperSize pkSize;
                //for (int i = 0; i < printDocument1.PrinterSettings.PaperSizes.Count; i++)
                //{
                //    pkSize = printDocument1.PrinterSettings.PaperSizes[i];
                //    comboBox1.Items.Add(pkSize);
                //}

                //// Create a PaperSize and specify the custom paper size through the constructor and add to combobox.
                //PaperSize pkCustomSize1 = new PaperSize("First custom size", 100, 200);

                //comboBox1.Items.Add(pkCustomSize1);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnShowPrint_Click(object sender, EventArgs e)
        {
           
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            MoneyChange(20);
        }

        private void MoneyChange(decimal odenen)
        {
           
            lblOdenen.Text = odenen.ToString();
            lblKalan.Text = (Convert.ToDecimal(lblOdenen.Text) - Convert.ToDecimal(lblTotalPrice.Text)).ToString();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            MoneyChange(30);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            MoneyChange(40);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            MoneyChange(50);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            MoneyChange(100);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            MoneyChange(200);
        }
    }
}
