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
            button1 = new Button();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(281, 202);
            button1.Name = "button1";
            button1.Size = new Size(206, 87);
            button1.TabIndex = 1;
            button1.Text = "Tedarikçiler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCategories);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockMasterApp Ana Menü";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategories;
        private Button button1;
    }
}
