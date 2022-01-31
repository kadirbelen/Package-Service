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
    public partial class fMusteriYok : Form
    {
        public fMusteriYok()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtCustomerName.Text;
            customer.Surname = txtCustomerSurname.Text;
            customer.Phone1 = txtPhone1.Text;
            customer.Phone2 = txtPhone2.Text;
            customer.Address1 = txtAddress1.Text;
            customer.Address2 = txtAddress2.Text;
            customer.Address3 = txtAddress3.Text;
            customer.CustomerNote = txtCustomerNote.Text;

            customerManager.Add(customer);
            MessageBox.Show("Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Hide();
        }
    }
}
