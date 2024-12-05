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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\mithra\gouri2024\togetherculture\Sofware-project\data\db_togetherculture.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);
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
