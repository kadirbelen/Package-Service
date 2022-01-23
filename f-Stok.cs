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

            foreach (var item in categoryManager.GetAll())
            {
                checkedListBox1.Items.Add(item.CategoryName);
            }
            checkedListBox1.CheckOnClick = true;//seçimi tek tıklama ile yapar
        }
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        private void f_Stok_Load(object sender, EventArgs e)
        {
            //SearchProductDate(dateTimePicker1.Value,dateTimePicker2.Value);
        }
        public void SearchProductCategories(string key)
        {
            var result = productManager.GetProductStockSearch(key).ToList();
            
            dataGridView1.DataSource = result + dataGridView1.DataSource.ToString();

        }
        public void SearchProductDate(DateTime dateTime1, DateTime dateTime2)
        {
            var result = productManager.GetProductSearchDate(dateTime1, dateTime2);
            dataGridView1.DataSource = result;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //{

            //    var value = checkedListBox1.CheckedItems[i];
            //    SearchProductCategories(value.ToString());
            //}

            SearchProductDate(dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductStockReport productStockReport = new ProductStockReport();
            productStockReport.ShowDialog();
        }
    }
}
