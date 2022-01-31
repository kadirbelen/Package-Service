using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class f_Stok : Form
    {
        public f_Stok()
        {
            InitializeComponent();

            var categoryList = categoryManager.GetAll();
            cmbCategoryList.DataSource = categoryList;
            cmbCategoryList.DisplayMember = "CategoryName";
            cmbCategoryList.ValueMember = "CategoryId";
            //foreach (var item in categoryManager.GetAll())
            //{
            //    checkedListBox1.Items.Add(item.CategoryName);
            //}
            //checkedListBox1.CheckOnClick = true;//seçimi tek tıklama ile yapar
        }
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        bool IsClick = false;
        private void f_Stok_Load(object sender, EventArgs e)
        {

            //SearchProductDate(dateTimePicker1.Value,dateTimePicker2.Value);
        }
      
        public void SearchProductDate(DateTime dateTime1, DateTime dateTime2)
        {
            var result = productManager.GetProductSearchDate(dateTime1, dateTime2);
            dataGridView1.DataSource = result.Select(x => new
            {
                x.ProductId,
                x.CategoryName,
                x.ProductName,
                x.Stock,
                x.ProductDate
            }).ToList();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //{

            //    var value = checkedListBox1.CheckedItems[i];
            //    SearchProductCategories(value.ToString());
            //}
            SearchProductDate(dateTimePicker1.Value, dateTimePicker2.Value);

            if (listBox1.SelectedIndex==0)
            {
                SearchProductDate(dateTimePicker1.Value, dateTimePicker2.Value);
            }
            else if(listBox1.SelectedIndex==1)
            {
                var result= productManager.GetProductStockCategoryId(dateTimePicker1.Value, dateTimePicker2.Value, (int)cmbCategoryList.SelectedValue);
                dataGridView1.DataSource = result.Select(x => new
                {
                    x.ProductId,
                    x.CategoryName,
                    x.ProductName,
                    x.Stock,
                    x.ProductDate
                }).ToList();
               
                MessageBox.Show("Ürün grubuna göre filtrele");
            }
           




        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductStockReport productStockReport = new ProductStockReport();
            productStockReport.ShowDialog();
        }

        
    }
}
