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
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PackageServiceDBDataSet.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.PackageServiceDBDataSet.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
