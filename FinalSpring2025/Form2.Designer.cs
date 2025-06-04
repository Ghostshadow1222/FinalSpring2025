namespace FinalSpring2025
{
    partial class Form2
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
            CustomerNameTxt = new TextBox();
            CustomerEmailTxt = new TextBox();
            AddCustomerBtn = new Button();
            CustomerDobTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 90);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth:";
            // 
            // CustomerNameTxt
            // 
            CustomerNameTxt.Location = new Point(129, 25);
            CustomerNameTxt.Name = "CustomerNameTxt";
            CustomerNameTxt.Size = new Size(100, 23);
            CustomerNameTxt.TabIndex = 3;
            // 
            // CustomerEmailTxt
            // 
            CustomerEmailTxt.Location = new Point(129, 87);
            CustomerEmailTxt.Name = "CustomerEmailTxt";
            CustomerEmailTxt.Size = new Size(100, 23);
            CustomerEmailTxt.TabIndex = 4;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.Location = new Point(49, 210);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(156, 46);
            AddCustomerBtn.TabIndex = 6;
            AddCustomerBtn.Text = "Add Customer";
            AddCustomerBtn.UseVisualStyleBackColor = true;
            AddCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // CustomerDobTxt
            // 
            CustomerDobTxt.Location = new Point(129, 156);
            CustomerDobTxt.Name = "CustomerDobTxt";
            CustomerDobTxt.Size = new Size(100, 23);
            CustomerDobTxt.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 281);
            Controls.Add(CustomerDobTxt);
            Controls.Add(AddCustomerBtn);
            Controls.Add(CustomerEmailTxt);
            Controls.Add(CustomerNameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Customers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox CustomerNameTxt;
        private TextBox CustomerEmailTxt;
        private Button AddCustomerBtn;
        private TextBox CustomerDobTxt;
    }
}