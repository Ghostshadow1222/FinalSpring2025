namespace FinalSpring2025
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTxt = new TextBox();
            PriceTxt = new TextBox();
            CategoryTxt = new TextBox();
            AddDessertBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 161);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(131, 27);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(100, 23);
            NameTxt.TabIndex = 3;
            // 
            // PriceTxt
            // 
            PriceTxt.Location = new Point(131, 91);
            PriceTxt.Name = "PriceTxt";
            PriceTxt.Size = new Size(100, 23);
            PriceTxt.TabIndex = 4;
            // 
            // CategoryTxt
            // 
            CategoryTxt.Location = new Point(131, 158);
            CategoryTxt.Name = "CategoryTxt";
            CategoryTxt.Size = new Size(100, 23);
            CategoryTxt.TabIndex = 5;
            // 
            // AddDessertBtn
            // 
            AddDessertBtn.Location = new Point(50, 210);
            AddDessertBtn.Name = "AddDessertBtn";
            AddDessertBtn.Size = new Size(156, 48);
            AddDessertBtn.TabIndex = 6;
            AddDessertBtn.Text = "Add Dessert";
            AddDessertBtn.UseVisualStyleBackColor = true;
            AddDessertBtn.Click += AddDessertBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 283);
            Controls.Add(AddDessertBtn);
            Controls.Add(CategoryTxt);
            Controls.Add(PriceTxt);
            Controls.Add(NameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Desserts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTxt;
        private TextBox PriceTxt;
        private TextBox CategoryTxt;
        private Button AddDessertBtn;
    }
}