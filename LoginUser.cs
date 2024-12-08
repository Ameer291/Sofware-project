using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sofware_project
{
    internal class LoginUser
    {
        private static readonly LoginUser instance = new LoginUser();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static LoginUser()
        {
        }

        private LoginUser()
        {
        }
        public static LoginUser GetInstance
        {
            get
            {
                return instance;
            }
        }
        public void SetCurrentUser(User CurrentUser)
        {
            this.CurrentUser = CurrentUser;
        }
        public User GetCurrentUser()
        {
            return CurrentUser;
        }
        public bool UpdateToDB()
        {
            try
            {
                DBConnection DBcon = new DBConnection();
                SqlConnection sqlcon = DBcon.ConnectDB();
                var query = "UPDATE Users SET Password = @Password, " +
                    "Email = @Email, " +
                    "FirstName =@FirstName, " +
                    "LastName = @LastName, " +
                    "Dateofbirth = @Dateofbirth, " +
                    "Gender = @Gender, " +
                    "Address = @Address, " +
                    "Phone = @Phone" +
                    " WHERE UserName = '" + CurrentUser.GetUsername() + "'";

                using (var cmd = new SqlCommand(query, sqlcon ))
                {
                    // cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", CurrentUser.GetEmail());
                    cmd.Parameters.AddWithValue("@Password", CurrentUser.GetPassword());
                    cmd.Parameters.AddWithValue("@FirstName", CurrentUser.GetFirstName());
                    cmd.Parameters.AddWithValue("@LastName", CurrentUser.GetLastName());
                    cmd.Parameters.AddWithValue("@Dateofbirth", CurrentUser.GetDOB());
                    cmd.Parameters.AddWithValue("@Gender", CurrentUser.GetGender());
                    cmd.Parameters.AddWithValue("@Address", CurrentUser.GetAddress());
                    cmd.Parameters.AddWithValue("@Phone", CurrentUser.GetPhoneNumber());
                    Image img = CurrentUser.GetPhoto();
                    if (img != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.ToArray();
                        cmd.Parameters.Add("@Photo", SqlDbType.Binary, 8000).Value = bytes;
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private User CurrentUser;
    }
}
