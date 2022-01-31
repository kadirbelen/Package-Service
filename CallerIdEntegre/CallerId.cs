using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraBars.Alerter;
using System.Windows.Forms;
using Eyp_PaketServisv1._2.Properties;
using Entities.Concrete;

namespace Eyp_PaketServisv1._2.CallerIdEntegre
{
    public class CallerId
    {

        [DllImport("cid.dll", EntryPoint = "CidData", CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string CidData();

        [DllImport("cid.dll", EntryPoint = "CidStart")]
        public static extern string CidStart();
        System.Threading.Timer timer;
        public event EventHandler<CallerIdEventArgs> AlertYeniKayit;
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        Form _form;
        AlertControl control;
        Customer customer;

        public CallerId(Form form)
        {
            control = new AlertControl();
            control.Buttons.Add(new AlertButton
            {
                Hint= "Yeni Kayıt Ekle",
                Name = "Yeni Kayıt Ekle",
                Image = Resources.icons8_customer_1.ToBitmap()

            }) ;
            control.ButtonClick += AlertButtonClick;

            _form = form;
            timer = new System.Threading.Timer(TimerElapsed, null, 0, 100);
            CidStart();
        }

        private void AlertButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            //AlertYeniKayit?.Invoke(this, new CallerIdEventArgs
            //{
            //    Customer = customer
            //});
            if (customer.Name == null)
            {
                fMusteriYok musteriYok = new fMusteriYok();
                musteriYok.Show();
                musteriYok.txtPhone1.Text = customer.Phone1;
            }
            else
            {
                fMusteriVar musteriVar = new fMusteriVar();
                musteriVar.Show();
                musteriVar.txtCustomerId.Text = customer.CustomerId.ToString();
                musteriVar.txtCustomerName.Text = customer.Name;
                musteriVar.txtCustomerSurname.Text = customer.Surname;
                musteriVar.txtPhone1.Text = customer.Phone1;
                musteriVar.txtPhone2.Text = customer.Phone2;
                musteriVar.txtAddress1.Text = customer.Address1;
                musteriVar.txtAddress2.Text = customer.Address2;
                musteriVar.txtAddress3.Text = customer.Address3;
                musteriVar.txtCustomerNote.Text = customer.CustomerNote;

            }
        }
        
        private void TimerElapsed(object state)
        {
            string temp = "";
            temp = CidData();
            if (!String.IsNullOrEmpty(temp))
            {
                string[] tempData = temp.Split(',');
                string phone = tempData[2];
                if (tempData[2].StartsWith("+90"))
                {
                    phone = tempData[2].Remove(0, 3);
                }
                if(tempData[2].StartsWith("0"))
                {
                    phone = tempData[2].Remove(0, 1);
                }
                var result = customerManager.GetPhoneCustomerList(phone);

                if (result == null)
                {
                    customer = new Customer
                    {
                        Phone1 = phone
                    };
                    _form.Invoke((Action)delegate
                    {
                        control.Show(_form, " Kayıtsız Müşteri", phone);
                    });

                }
                else
                {
                    customer = result;
                    _form.Invoke((Action)delegate
                    {
                        control.Show(_form, result.Name + " " + result.Surname, phone);
                    });

                }

            }
        }
    }

    public class ConstCharPtrMarshaler : ICustomMarshaler
    {
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.PtrToStringAnsi(pNativeData);
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            return IntPtr.Zero;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        static readonly ConstCharPtrMarshaler instance = new ConstCharPtrMarshaler();

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return instance;
        }
    }
}
