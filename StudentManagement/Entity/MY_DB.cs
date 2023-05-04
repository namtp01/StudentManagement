using System.Data.SqlClient;
using System.Data;

namespace StudentManagement.Entity
{
    class MY_DB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-7nb7k4a7\SQLEXPRESS;Initial Catalog=QLSVDB;
                Integrated Security=True;Connect Timeout=30;Encrypt=False;
                TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");

        public SqlConnection getConnection
        {
            get { return conn; }
        }

        public void openConnection()
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if ((conn.State == ConnectionState.Open))
            {
                conn.Close();
            }
        }
    }
}
