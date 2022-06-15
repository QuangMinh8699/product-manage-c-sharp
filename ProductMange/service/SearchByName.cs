using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMange.entity;
using ProductMange.connect;
using System.Data.SqlClient;

namespace ProductMange.service
{
    public class SearchByName
    {
        public static void searchProductByName()
        {
            Product product = new Product();
            Console.Write("Enter your product's name: ");
            product.proName = Console.ReadLine();
            ConnectDB connectDB = new ConnectDB();
            SqlConnection sqlConnection = connectDB.GetSqlConnection();

            string query = "SELECT * FORM minhdeptrai WHERE proName=@proName";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlParameter proName = new SqlParameter("@proName", product.proName);


            command.Parameters.Add(proName);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("product name: " + reader[1]);
            }
            sqlConnection.Close();

        }
    }
}
