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
    public class Add
    {
        public static void create()
        {
            Product product = new Product();    
            Console.Write("Enter your product's name: ");
            product.proName = Console.ReadLine();
            Console.Write("Enter your product's descripiton: ");
            product.proDesc = Console.ReadLine();
            Console.Write("Enter your product's price: ");
            product.proPrice = Convert.ToDouble(Console.ReadLine());

            ConnectDB connectDB = new ConnectDB();
            SqlConnection sqlConnection = connectDB.GetSqlConnection();
            string query = "INSERT INTO Product VALUES(@proName, @proDesc, @proPrice)";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlParameter proName = new SqlParameter("@proName", product.proName);
            SqlParameter proDesc = new SqlParameter("@proDesc", product.proDesc);
            SqlParameter proPrice = new SqlParameter("@proPrice", product.proPrice);

            command.Parameters.Add(proName);
            command.Parameters.Add(proDesc);
            command.Parameters.Add(proPrice);
            
            sqlConnection.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Add product {0} successfully", dataCount);
            sqlConnection.Close();

        }
    }
}
