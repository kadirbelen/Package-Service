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
    public partial class f_UrunGrubu : Form
    {
        public f_UrunGrubu()
        {
            InitializeComponent();
        }
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        private void categoryAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                Category category = new Category();
                category.CategoryName = txtCategoryName.Text;
                categoryManager.Add(category);
                MessageBox.Show("Ürün Grubu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                List();
            }
            else
            {
                MessageBox.Show("Kategori eklenemedi");
            }
        }

        public void List()
        {
            var result = categoryManager.GetAll();

            dataGridView1.DataSource = result;

            

        }

        private void f_UrunGrubu_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            var result = categoryManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value));
            result.IsActive = false;
            categoryManager.Update(result);

            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }
    }
}
