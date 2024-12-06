using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofware_project
{
    internal class DBConnection
    {
        private SqlConnection conn;
        public SqlConnection ConnectDB()
        {
            string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "Integrated Security=true";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

            // String cs = AppDomain.CurrentDomain.BaseDirectory;
            string DBpath = AppDomain.CurrentDomain.BaseDirectory + "db_togetherculture.MDF";
            builder.AttachDBFilename = DBpath; //@"C:\mithra\gouri2024\software projet\software projet\bin\Debug\net8.0-windows\mydb.MDF";
            // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DBpath|;Integrated Security=True";
            conn = new SqlConnection(builder.ConnectionString);
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return conn;
            }
        }

            public void CloseDBConnection()
            {
            }

    }
}
