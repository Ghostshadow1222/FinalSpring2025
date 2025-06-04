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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            // Assuming data will be valid

            string name = NameTxt.Text;
            string email = EmailTxt.Text;
            DateTime dateOfBirth = Convert.ToDateTime(DateOfBirthTxt.Text);

            Customer customer = new Customer(name, email, dateOfBirth);

            CustomerDB.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
            Close();
        }
    }
}
