
namespace Eyp_PaketServisv1._2
{
    partial class ProductStockReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PackageServiceDBDataSet = new Eyp_PaketServisv1._2.PackageServiceDBDataSet();
            this.ProductStocReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductStocReportsTableAdapter = new Eyp_PaketServisv1._2.PackageServiceDBDataSetTableAdapters.ProductStocReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PackageServiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStocReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProductStock1";
            reportDataSource1.Value = this.ProductStocReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eyp_PaketServisv1._2.ProductStockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PackageServiceDBDataSet
            // 
            this.PackageServiceDBDataSet.DataSetName = "PackageServiceDBDataSet";
            this.PackageServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductStocReportsBindingSource
            // 
            this.ProductStocReportsBindingSource.DataMember = "ProductStocReports";
            this.ProductStocReportsBindingSource.DataSource = this.PackageServiceDBDataSet;
            // 
            // ProductStocReportsTableAdapter
            // 
            this.ProductStocReportsTableAdapter.ClearBeforeFill = true;
            // 
            // ProductStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductStockReport";
            this.Text = "ProductStockReport";
            this.Load += new System.EventHandler(this.ProductStockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PackageServiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStocReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductStocReportsBindingSource;
        private PackageServiceDBDataSet PackageServiceDBDataSet;
        private PackageServiceDBDataSetTableAdapters.ProductStocReportsTableAdapter ProductStocReportsTableAdapter;
    }
}