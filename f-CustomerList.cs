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
    public partial class f_CustomerList : Form
    {
        public f_CustomerList()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        FormSiparis f1siparis = (FormSiparis)Application.OpenForms["FormSiparis"];
        private void f_CustomerList_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource=customerManager.GetAll();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerManager.GetAll();
        }

        private void müşteriSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id=dataGridView1.CurrentRow.Cells["CustomerId"].Value;
            var result =customerManager.GetById(Convert.ToInt32(id));
            f1siparis.lblCustomerName.Text = result.Name+" "+result.Surname+" "+result.Phone1;
            f1siparis.CustomerId = Convert.ToInt32(id);
        }

      
    }
}
