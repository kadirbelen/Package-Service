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
    public partial class fMusteriVar : Form
    {
        public fMusteriVar()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        private void fMusteriVar_Load(object sender, EventArgs e)
        {

        }

        //public void List(string phone)
        //{
        //    var result = customerManager.GetById(phone);
        //    txtCustomerName.Text = result.Name;
        //    txtCustomerSurname.Text = result.Surname;
        //    txtAddress1.Text = result.Address1;
        //    txtAddress2.Text = result.Address2;
        //    txtAddress3.Text = result.Address3;
        //    txtPhone1.Text = result.Phone1;
        //    txtPhone2.Text = result.Phone2;
        //    txtCustomerNote.Text = result.CustomerNote;
            
        //}
    }
}
