using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public SqlConnection Connect()
        {
            string strconn = @"Data Source=ZEPHYRUS\\SQLEXPRESS;Initial Catalog=ProductManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }    
    public class DatabaseAccess
    {
        
    }
}
