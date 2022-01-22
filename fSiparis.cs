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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id:"+CustomerId.ToString());
        }
    }
}
