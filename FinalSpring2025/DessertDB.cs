using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    static class DessertDB
    {
        public static void AddDessert(Dessert dessert)
        {
            SqlConnection con = GetDbConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Desserts(Name, Price, Category) " +
                "VALUES (@name, @price, @category)";
            insertCmd.Parameters.AddWithValue("@name", dessert.Name);
            insertCmd.Parameters.AddWithValue("@price", dessert.Price);
            insertCmd.Parameters.AddWithValue("@category", dessert.Category);

            con.Open();

            insertCmd.ExecuteNonQuery();

            con.Close();
        }

        private static SqlConnection GetDbConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=BonSucre;Integrated Security=True");
        }

        public static List<Dessert> GetAllDesserts()
        {
            SqlConnection con = GetDbConnection();

            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "SELECT DessertId, Name, Price, Category " +
                " FROM Desserts " +
                " ORDER BY Name";

            con.Open();

            SqlDataReader reader = selCmd.ExecuteReader();

            List<Dessert> desserts = new List<Dessert>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["DessertId"]);
                string name = reader["Name"].ToString();
                double price = Convert.ToDouble(reader["Price"]);
                string category = reader["Category"].ToString();

                Dessert tempDessert = new Dessert(name, price, category);
                tempDessert.DessertId = id;
                
                desserts.Add(tempDessert);
            }

            con.Close();

            return desserts;
        }
    }
}
