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
    public partial class ProductStockReport : Form
    {
        public ProductStockReport()
        {
            InitializeComponent();
        }
        f_Stok f_Stok = (f_Stok)Application.OpenForms["f_Stok"];

        private void ProductStockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PackageServiceDBDataSet.ProductStocReports' table. You can move, or remove it, as needed.
            this.ProductStocReportsTableAdapter.Fill(this.PackageServiceDBDataSet.ProductStocReports, f_Stok.dateTimePicker1.Value, f_Stok.dateTimePicker2.Value);//dateTimePicker1.Value, dateTimePicker2.Value

            this.reportViewer1.RefreshReport();
        }
    }
}
