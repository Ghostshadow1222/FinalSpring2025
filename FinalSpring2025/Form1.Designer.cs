namespace FinalSpring2025
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
            CustomerCmb = new ComboBox();
            DessertCmb = new ComboBox();
            groupBox1 = new GroupBox();
            ReviewBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ReviewTxt = new TextBox();
            CustomerBtn = new Button();
            DessertBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerCmb
            // 
            CustomerCmb.FormattingEnabled = true;
            CustomerCmb.Location = new Point(153, 70);
            CustomerCmb.Name = "CustomerCmb";
            CustomerCmb.Size = new Size(164, 23);
            CustomerCmb.TabIndex = 0;
            // 
            // DessertCmb
            // 
            DessertCmb.FormattingEnabled = true;
            DessertCmb.Location = new Point(153, 151);
            DessertCmb.Name = "DessertCmb";
            DessertCmb.Size = new Size(164, 23);
            DessertCmb.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ReviewBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ReviewTxt);
            groupBox1.Controls.Add(CustomerCmb);
            groupBox1.Controls.Add(DessertCmb);
            groupBox1.Location = new Point(53, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 384);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Review";
            // 
            // ReviewBtn
            // 
            ReviewBtn.Location = new Point(109, 297);
            ReviewBtn.Name = "ReviewBtn";
            ReviewBtn.Size = new Size(171, 62);
            ReviewBtn.TabIndex = 6;
            ReviewBtn.Text = "Add Review";
            ReviewBtn.UseVisualStyleBackColor = true;
            ReviewBtn.Click += ReviewBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 237);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Review (1 - 5):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 154);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Dessert:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 73);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Customer:";
            // 
            // ReviewTxt
            // 
            ReviewTxt.Location = new Point(153, 234);
            ReviewTxt.Name = "ReviewTxt";
            ReviewTxt.Size = new Size(100, 23);
            ReviewTxt.TabIndex = 2;
            // 
            // CustomerBtn
            // 
            CustomerBtn.Location = new Point(474, 69);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(195, 135);
            CustomerBtn.TabIndex = 3;
            CustomerBtn.Text = "Add Customer";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // DessertBtn
            // 
            DessertBtn.Location = new Point(474, 260);
            DessertBtn.Name = "DessertBtn";
            DessertBtn.Size = new Size(195, 125);
            DessertBtn.TabIndex = 4;
            DessertBtn.Text = "Add Dessert";
            DessertBtn.UseVisualStyleBackColor = true;
            DessertBtn.Click += DessertBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(DessertBtn);
            Controls.Add(CustomerBtn);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bon Sucre";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CustomerCmb;
        private ComboBox DessertCmb;
        private GroupBox groupBox1;
        private Button ReviewBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ReviewTxt;
        private Button CustomerBtn;
        private Button DessertBtn;
    }
}
