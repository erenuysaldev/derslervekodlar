namespace WindowsForm01_Intro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            cbAgree = new CheckBox();
            cmbCategoryList = new ComboBox();
            btnSave = new ListBox();
            notifyIcon1 = new NotifyIcon(components);
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(59, 83);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbAgree
            // 
            cbAgree.AutoSize = true;
            cbAgree.Location = new Point(84, 337);
            cbAgree.Name = "cbAgree";
            cbAgree.Size = new Size(159, 24);
            cbAgree.TabIndex = 1;
            cbAgree.Text = "okudum onayladım";
            cbAgree.UseVisualStyleBackColor = true;
            // 
            // cmbCategoryList
            // 
            cmbCategoryList.FormattingEnabled = true;
            cmbCategoryList.Location = new Point(529, 68);
            cmbCategoryList.Name = "cmbCategoryList";
            cmbCategoryList.Size = new Size(151, 28);
            cmbCategoryList.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.FormattingEnabled = true;
            btnSave.Location = new Point(537, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 104);
            btnSave.TabIndex = 3;
            btnSave.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(325, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(btnSave);
            Controls.Add(cmbCategoryList);
            Controls.Add(cbAgree);
            Controls.Add(button1);
            Name = "Form1";
            Text = "İlk Uygulamam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox cbAgree;
        private ComboBox cmbCategoryList;
        private ListBox btnSave;
        private NotifyIcon notifyIcon1;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}
