namespace StockMasterApp
{
    partial class CategoriesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCategories = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gridCategories = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            SuspendLayout();
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 20F);
            btnCategories.Location = new Point(251, 12);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(206, 87);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 333);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori Ekle/Düzenle";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(248, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(136, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 199);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(270, 27);
            txtDescription.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 153);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı";
            // 
            // gridCategories
            // 
            gridCategories.AllowUserToAddRows = false;
            gridCategories.AllowUserToDeleteRows = false;
            gridCategories.AllowUserToResizeColumns = false;
            gridCategories.AllowUserToResizeRows = false;
            gridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategories.Location = new Point(405, 114);
            gridCategories.Name = "gridCategories";
            gridCategories.RowHeadersWidth = 51;
            gridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategories.Size = new Size(396, 324);
            gridCategories.TabIndex = 2;
            gridCategories.CellEnter += gridCategories_CellEnter;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(gridCategories);
            Controls.Add(groupBox1);
            Controls.Add(btnCategories);
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockMasterApp Ana Menü";
            Load += CategoriesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategories;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DataGridView gridCategories;
    }
}
