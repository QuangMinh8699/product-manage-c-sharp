using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductMange.connect;

namespace ProductMange.service
{
    public class Show
    {
        public static void getAll()
        {
            ConnectDB connectionString = new ConnectDB();
            SqlConnection connection = connectionString.GetSqlConnection();

            string query = "select * from product";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Product's name :" + reader[1]);
            }
            connection.Close();
        }
        
    }
}
