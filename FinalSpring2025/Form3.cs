using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSpring2025
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void AddDessertBtn_Click(object sender, EventArgs e)
        {
            // Assuming all data will be valid

            string name = NameTxt.Text;
            double price = Convert.ToDouble(PriceTxt.Text);
            string category = CategoryTxt.Text;

            Dessert dessert = new Dessert(name, price, category);

            DessertDB.AddDessert(dessert);
            MessageBox.Show("Dessert added successfully!");
            Close();
        }
    }
}
