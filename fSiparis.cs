using Business.Abstract;
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
    public partial class fSiparis : Form
    {
        public fSiparis()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public int CustomerId;
        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void btnCustomerShow_Click(object sender, EventArgs e)
        {
            f_CustomerList f_CustomerList = new f_CustomerList();
            f_CustomerList.ShowDialog();
        }

        private void fSiparis_Load(object sender, EventArgs e)
        {

            var result = categoryManager.GetAll();
            List<Button> btn = new List<Button>() { btn0,btn1, btn2, btn3, btn4, btn5, btn6, btn7 };
           
            for (int i = 0; i < result.Count; i++)
            {
                
                btn[i].Text = result[i].CategoryName.ToUpper();
                btn[i].Name= result[i].CategoryId.ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id:"+CustomerId.ToString());
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            var result = productManager.GetByIdList(Convert.ToInt32(btn0.Name));
            dataGridView1.DataSource = result;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var result = productManager.GetByIdList(Convert.ToInt32(btn1.Name));
            dataGridView1.DataSource = result;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var result = productManager.GetByIdList(Convert.ToInt32(btn2.Name));
            dataGridView1.DataSource = result;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           
            var result = productManager.GetByIdList(Convert.ToInt32(btn3.Name));
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCustomerName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
