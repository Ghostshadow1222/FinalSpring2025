using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    static class CustomerDB
    {
        public static void AddCustomer(Customer customer)
        {
            SqlConnection con = GetDbConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Customers(Name, Email, DateOfBirth) " +
                "VALUES (@name, @email, @dateOfBirth)";
            insertCmd.Parameters.AddWithValue("@name", customer.Name);
            insertCmd.Parameters.AddWithValue("@email", customer.Email);
            insertCmd.Parameters.AddWithValue("@dateOfBirth", customer.DateOfBirth);

            con.Open();

            insertCmd.ExecuteNonQuery();

            con.Close();
        }

        private static SqlConnection GetDbConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=BonSucre;Integrated Security=True");
        }

        /// <summary>
        /// Retrieves a list of all customers from the database by name in ascending order.
        /// </summary>
        /// <returns>A list of <see cref="Customer"/> objects representing all customers in the database.</returns>
        public static List<Customer> GetAllCustomers()
        {
            // Make connection to the database
            SqlConnection con = GetDbConnection();

            // Create select query
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "SELECT CustomerId, Name, Email, DateOfBirth " +
                " FROM Customers" +
                " ORDER BY Name";

            // Open connection
            con.Open();

            // Use select query to get data from the database
            SqlDataReader reader = selCmd.ExecuteReader();

            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["CustomerId"]);
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                DateTime dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                Customer tempCustomer = new Customer(name, email, dateOfBirth);
                tempCustomer.CustomerId = id;

                customers.Add(tempCustomer);
            }

            // Close connection
            con.Close();

            // Return list of customers
            return customers;
        }
    }
}
