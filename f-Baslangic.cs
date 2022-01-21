using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyp_PaketServisv1._2
{
    public partial class f_Baslangic : Form
    {
        public f_Baslangic()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f_UrunGiris f_UrunGiris = new f_UrunGiris();
            f_UrunGiris.ShowDialog();
        }

        private void btnPriceChange_Click(object sender, EventArgs e)
        {
            f_FiyatGüncelle f_FiyatGüncelle = new f_FiyatGüncelle();
            f_FiyatGüncelle.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            f_Stok f_Stok = new f_Stok();
            f_Stok.ShowDialog();
        }

        private void f_Baslangic_Load(object sender, EventArgs e)
        {
           // VeriTabaniEkleme();
        }

        private static void VeriTabaniEkleme()
        {
            PackageServiceDbContext context = new PackageServiceDbContext();
            context.Database.Create();
            MessageBox.Show("eklendi");
        }

        private static void VeriTabaniSilme()
        {
            PackageServiceDbContext context = new PackageServiceDbContext();
            context.Database.Delete();
            MessageBox.Show("silindi");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
