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
    public partial class fMusteriVar : Form
    {
        public fMusteriVar()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        FormSiparis f1siparis = (FormSiparis)Application.OpenForms["FormSiparis"];
        private void fMusteriVar_Load(object sender, EventArgs e)
        {

        }
        Customer customer;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            customer = customerManager.GetById(Convert.ToInt32(txtCustomerId.Text));
            customer.Name = txtCustomerName.Text;
            customer.Surname = txtCustomerSurname.Text;
            customer.Phone1 = txtPhone1.Text;
            customer.Phone2 = txtPhone2.Text;
            customer.Address1 = txtAddress1.Text;
            customer.Address2 = txtAddress2.Text;
            customer.Address3 = txtAddress3.Text;
            customer.CustomerNote = txtCustomerNote.Text;

            customerManager.Update(customer);
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            f1siparis.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            f1siparis.lblCustomerName.Text = txtCustomerName.Text + " " + txtCustomerSurname.Text + " " + txtPhone1.Text;
            this.Close();
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
