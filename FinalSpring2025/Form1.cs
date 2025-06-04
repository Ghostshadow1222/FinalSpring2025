namespace FinalSpring2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer customer in customers)
            {
                CustomerCmb.Items.Add(customer);
            }

            List<Dessert> desserts = DessertDB.GetAllDesserts();

            foreach (Dessert dessert in desserts)
            {
                DessertCmb.Items.Add(dessert);
            }

        }
    }
}
