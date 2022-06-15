using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductMange.connect
{
    public class ConnectDB
    {
        public SqlConnection GetSqlConnection()
        {
            string connectionString = "Server = CARAMEL14\\SQLEXPRESS;" +
                " Initial Catalog =minhdeptrai; Integrated Security= SSPI";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
