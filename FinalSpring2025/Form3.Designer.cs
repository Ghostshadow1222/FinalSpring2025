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
            DessertNameTxt = new TextBox();
            DessertPriceTxt = new TextBox();
            DessertCategoryTxt = new TextBox();
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
            // DessertNameTxt
            // 
            DessertNameTxt.Location = new Point(131, 27);
            DessertNameTxt.Name = "DessertNameTxt";
            DessertNameTxt.Size = new Size(100, 23);
            DessertNameTxt.TabIndex = 3;
            // 
            // DessertPriceTxt
            // 
            DessertPriceTxt.Location = new Point(131, 91);
            DessertPriceTxt.Name = "DessertPriceTxt";
            DessertPriceTxt.Size = new Size(100, 23);
            DessertPriceTxt.TabIndex = 4;
            // 
            // DessertCategoryTxt
            // 
            DessertCategoryTxt.Location = new Point(131, 158);
            DessertCategoryTxt.Name = "DessertCategoryTxt";
            DessertCategoryTxt.Size = new Size(100, 23);
            DessertCategoryTxt.TabIndex = 5;
            // 
            // AddDessertBtn
            // 
            AddDessertBtn.Location = new Point(50, 210);
            AddDessertBtn.Name = "AddDessertBtn";
            AddDessertBtn.Size = new Size(156, 48);
            AddDessertBtn.TabIndex = 6;
            AddDessertBtn.Text = "Add Dessert";
            AddDessertBtn.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 283);
            Controls.Add(AddDessertBtn);
            Controls.Add(DessertCategoryTxt);
            Controls.Add(DessertPriceTxt);
            Controls.Add(DessertNameTxt);
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
        private TextBox DessertNameTxt;
        private TextBox DessertPriceTxt;
        private TextBox DessertCategoryTxt;
        private Button AddDessertBtn;
    }
}