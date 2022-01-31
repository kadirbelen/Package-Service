using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class f_UrunGiris : Form
    {
        public f_UrunGiris()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        private void f_UrunGiris_Load(object sender, EventArgs e)
        {
           
            List();
 

            var categoryList = categoryManager.GetAll();
            cmbCategoryName.DataSource = categoryList;
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "CategoryId";
            
        }

        public void SearchProduct(string key)
        {
            var result = productManager.GetProductSearch(key);
            dataGridView1.DataSource = result;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //product.BarcodeNumber = txtBarcode.Text.ToUpper().Trim();
            product.ProductName = txtProductName.Text.ToUpper().Trim();
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.CategoryId = (int)cmbCategoryName.SelectedValue;//buraya Id cekilecek
            product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
            product.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            product.ProductDate = productDate.Value;
            product.VatRate = cmbVatRate.Text;
            product.VatAmount = Convert.ToDecimal(txtSalePrice.Text) * (Convert.ToDecimal(cmbVatRate.Text) / 100);
            productManager.Add(product);
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }
        public void List()
        {
            var result = productManager.GetProductOrCategoryDetails();
            txtProductCount.Text = result.Count.ToString();
            dataGridView1.DataSource = result;

        }

        private void CategoryAddPage_Click(object sender, EventArgs e)
        {
            f_UrunGrubu f_UrunGrubu = new f_UrunGrubu();
            f_UrunGrubu.ShowDialog();
        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            var result = productManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductId"].Value));
            result.IsActive = false;
            productManager.Update(result);

            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(txtSearchProduct.Text);
        }

        private void btnCreateBarcode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            ProductReport productReport = new ProductReport();
            productReport.ShowDialog();
        }
    }
}
