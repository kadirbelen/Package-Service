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
    public partial class f_FiyatGüncelle : Form
    {
        public f_FiyatGüncelle()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        private void f_FiyatGüncelle_Load(object sender, EventArgs e)
        {
            List();
            var categoryList = categoryManager.GetAll();
            cmbCategoryName.DataSource = categoryList;
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "CategoryId";
        }
        public void List()
        {
            var result = productManager.GetProductOrCategoryDetails();

            dataGridView1.DataSource = result;

        }

        public void SearchProduct(string key)
        {
            var result = productManager.GetProductSearch(key);
            dataGridView1.DataSource = result;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductId"].Value);
            //product.BarcodeNumber = txtBarcode.Text;
            product.ProductName = txtProductName.Text;
            product.CategoryId = (int)cmbCategoryName.SelectedValue;
            product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
            product.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.ProductDate = productDate.Value;
            product.VatRate = cmbVatRate.Text;
            product.VatAmount = Convert.ToDecimal(txtSalePrice.Text) * (Convert.ToDecimal(cmbVatRate.Text) / 100);

            productManager.Update(product);
            MessageBox.Show("Güncellendi....");
            List();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtBarcode.Text = dataGridView1.CurrentRow.Cells["BarcodeNumber"].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            cmbCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtPurchasePrice.Text = dataGridView1.CurrentRow.Cells["PurchasePrice"].Value.ToString();
            txtSalePrice.Text = dataGridView1.CurrentRow.Cells["SalePrice"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            cmbVatRate.Text = dataGridView1.CurrentRow.Cells["VatRate"].Value.ToString();
            productDate.Text = dataGridView1.CurrentRow.Cells["ProductDate"].Value.ToString();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(txtSearchProduct.Text);
        }
    }
}
