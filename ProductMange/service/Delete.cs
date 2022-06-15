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
    public class Delete
    {
        public static void deleteProduct()
        {
            Console.Write("Enter your product's name: ");
            string name = Console.ReadLine();

            ConnectDB connectDB = new ConnectDB();
            SqlConnection sqlConnection = connectDB.GetSqlConnection();

            string query = "DELETE FROM minhdeptrai WHERE proName=@proName";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlParameter proName = new SqlParameter("@proName", name);

            command.Parameters.Add(proName);
            sqlConnection.Open();
            int dataCount = command.EndExecuteNonQuery();
            Console.WriteLine("Delete" + dataCount + "successfully");
        }
    }
}
