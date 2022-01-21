
namespace Eyp_PaketServisv1._2
{
    partial class f_UrunGrubu
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryAdd = new System.Windows.Forms.Button();
            this.btnCategoryRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(27, 64);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(357, 30);
            this.txtCategoryName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Grubu Ekle";
            // 
            // categoryAdd
            // 
            this.categoryAdd.BackColor = System.Drawing.Color.Tomato;
            this.categoryAdd.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.categoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryAdd.ForeColor = System.Drawing.Color.White;
            this.categoryAdd.Location = new System.Drawing.Point(27, 550);
            this.categoryAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryAdd.Name = "categoryAdd";
            this.categoryAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryAdd.Size = new System.Drawing.Size(152, 70);
            this.categoryAdd.TabIndex = 9;
            this.categoryAdd.Text = "Ürün Grubu Ekle";
            this.categoryAdd.UseVisualStyleBackColor = false;
            this.categoryAdd.Click += new System.EventHandler(this.categoryAdd_Click);
            // 
            // btnCategoryRemove
            // 
            this.btnCategoryRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnCategoryRemove.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnCategoryRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryRemove.ForeColor = System.Drawing.Color.White;
            this.btnCategoryRemove.Location = new System.Drawing.Point(233, 550);
            this.btnCategoryRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.btnCategoryRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategoryRemove.Size = new System.Drawing.Size(152, 70);
            this.btnCategoryRemove.TabIndex = 9;
            this.btnCategoryRemove.Text = "Ürün Grubu Sil";
            this.btnCategoryRemove.UseVisualStyleBackColor = false;
            this.btnCategoryRemove.Click += new System.EventHandler(this.btnCategoryRemove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 389);
            this.dataGridView1.TabIndex = 10;
            // 
            // f_UrunGrubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCategoryRemove);
            this.Controls.Add(this.categoryAdd);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "f_UrunGrubu";
            this.Text = "f_UrunGrubu";
            this.Load += new System.EventHandler(this.f_UrunGrubu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categoryAdd;
        private System.Windows.Forms.Button btnCategoryRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}