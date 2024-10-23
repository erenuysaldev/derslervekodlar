namespace StockMasterApp
{
    partial class MainMenuForm
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
            btnSuppliers = new Button();
            btnProducts = new Button();
            SuspendLayout();
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 20F);
            btnCategories.Location = new Point(281, 70);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(206, 87);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI", 20F);
            btnSuppliers.Location = new Point(281, 190);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(206, 87);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Tedarikçiler";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += button1_Click;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 20F);
            btnProducts.Location = new Point(281, 298);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(206, 87);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Ürünler";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProducts);
            Controls.Add(btnSuppliers);
            Controls.Add(btnCategories);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockMasterApp Ana Menü";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnProducts;
    }
}
