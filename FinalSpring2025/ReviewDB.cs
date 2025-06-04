using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    static class ReviewDB
    {
        /// <summary>
        /// Adds a review to the database.
        /// </summary>
        /// <param name="review">Review to be added</param>
        
        public static void AddReview(Review review)
        {
            // Connecting to the database
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=BonSucre;Integrated Security=True");

            // Making insert query
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            // Paramaterized queries 
            insertCmd.CommandText = "INSERT INTO Reviews(CustomerId, DessertId, Score)" +
                "VALUES (@customerId, @dessertId, @score)";
            insertCmd.Parameters.AddWithValue("@customerId", review.CustomerId);
            insertCmd.Parameters.AddWithValue("@dessertId", review.DessertId);
            insertCmd.Parameters.AddWithValue("@score", review.Score);

            // Opening connection to database
            con.Open();

            // Execute insert query
            insertCmd.ExecuteNonQuery();

            // Close connection to database
            con.Close();

        }
    }
}
