namespace StockMasterApp.Forms
{
    partial class ProductsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnAddStockTranscation = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbSuppliers = new ComboBox();
            cmbCategories = new ComboBox();
            rbFalse = new RadioButton();
            rbTrue = new RadioButton();
            txtReorderLevel = new TextBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            gridProducts = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddStockTranscation);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cmbSuppliers);
            groupBox1.Controls.Add(cmbCategories);
            groupBox1.Controls.Add(rbFalse);
            groupBox1.Controls.Add(rbTrue);
            groupBox1.Controls.Add(txtReorderLevel);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 641);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Ekle/Güncelle";
            // 
            // btnAddStockTranscation
            // 
            btnAddStockTranscation.BackColor = Color.DodgerBlue;
            btnAddStockTranscation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddStockTranscation.ForeColor = Color.White;
            btnAddStockTranscation.Location = new Point(316, 233);
            btnAddStockTranscation.Name = "btnAddStockTranscation";
            btnAddStockTranscation.Size = new Size(205, 44);
            btnAddStockTranscation.TabIndex = 4;
            btnAddStockTranscation.Text = "Stok Hareketi Ekle";
            btnAddStockTranscation.UseVisualStyleBackColor = false;
            btnAddStockTranscation.Click += btnAddStockTranscation_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(370, 563);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 56);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(194, 563);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 56);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(13, 563);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 56);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.Font = new Font("Segoe UI", 14F);
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(216, 468);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(305, 39);
            cmbSuppliers.TabIndex = 3;
            // 
            // cmbCategories
            // 
            cmbCategories.Font = new Font("Segoe UI", 14F);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(216, 409);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(305, 39);
            cmbCategories.TabIndex = 3;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Font = new Font("Segoe UI", 14F);
            rbFalse.Location = new Point(316, 299);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(72, 36);
            rbFalse.TabIndex = 2;
            rbFalse.Text = "Yok";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Checked = true;
            rbTrue.Font = new Font("Segoe UI", 14F);
            rbTrue.Location = new Point(216, 299);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(68, 36);
            rbTrue.TabIndex = 2;
            rbTrue.TabStop = true;
            rbTrue.Text = "Var";
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Font = new Font("Segoe UI", 14F);
            txtReorderLevel.Location = new Point(216, 352);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(305, 39);
            txtReorderLevel.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 14F);
            txtStock.Location = new Point(216, 234);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(81, 39);
            txtStock.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.Location = new Point(216, 175);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(305, 39);
            txtPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 14F);
            txtQuantity.Location = new Point(216, 116);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(305, 39);
            txtQuantity.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(216, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 39);
            txtName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(13, 485);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 0;
            label8.Text = "Tedarikçi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(13, 426);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 0;
            label7.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(13, 249);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 0;
            label4.Text = "Stok Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(13, 367);
            label6.Name = "label6";
            label6.Size = new Size(181, 28);
            label6.TabIndex = 0;
            label6.Text = "Stok Seviye Sınırı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(13, 190);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 0;
            label3.Text = "Birim Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(13, 308);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 0;
            label5.Text = "İndirim var mı?:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(13, 131);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 0;
            label2.Text = "Birim Adet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(13, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Ürün:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gridProducts);
            groupBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Location = new Point(562, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(914, 641);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürünler";
            // 
            // gridProducts
            // 
            gridProducts.AllowUserToAddRows = false;
            gridProducts.AllowUserToDeleteRows = false;
            gridProducts.AllowUserToResizeColumns = false;
            gridProducts.AllowUserToResizeRows = false;
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Dock = DockStyle.Bottom;
            gridProducts.Location = new Point(3, 42);
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            gridProducts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProducts.Size = new Size(908, 596);
            gridProducts.TabIndex = 0;
            gridProducts.CellEnter += gridProducts_CellEnter;
            gridProducts.DoubleClick += btnAddStockTranscation_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategories;
        private RadioButton rbFalse;
        private RadioButton rbTrue;
        private TextBox txtReorderLevel;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cmbSuppliers;
        private GroupBox groupBox2;
        private DataGridView gridProducts;
        private Button btnAddStockTranscation;
    }
}