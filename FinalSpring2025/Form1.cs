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
            PopulateReviewers();
        }

        private void PopulateReviewers()
        {
            CustomerCmb.Items.Clear();

            DessertCmb.Items.Clear();

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

        private void ReviewBtn_Click(object sender, EventArgs e)
        {
            int customerReview = (CustomerCmb.SelectedItem as Customer).CustomerId;
            int dessertReview = (DessertCmb.SelectedItem as Dessert).DessertId;
            int score = Convert.ToInt32(RatingTxt.Text);

            Review review = new Review
            {
                CustomerId = customerReview,
                DessertId = dessertReview,
                Score = score
            };

            ReviewDB.AddReview(review);
            MessageBox.Show("Review added successfully!");
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Form2 customerForm = new Form2();
            customerForm.ShowDialog();
            PopulateReviewers();
        }

        private void DessertBtn_Click(object sender, EventArgs e)
        {
            Form3 dessertForm = new Form3();
            dessertForm.ShowDialog();
            PopulateReviewers();
        }
    }
}
