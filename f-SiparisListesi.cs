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
    public partial class f_SiparisListesi : Form
    {
        public f_SiparisListesi()
        {
            InitializeComponent();
        }
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = orderManager.GetCustomerPhoneList(mskPhone.Text);
            dataGridView1.DataSource = result;
            
        }

        private void f_SiparisListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
