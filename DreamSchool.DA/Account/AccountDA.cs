using DreamSchool.BO.Account;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.Account
{
    public class AccountDA : BaseDA
    {
        #region Column Names

        private const string CLMN_Username = "Username";
        private const string CLMN_Password = "Password";
        private const string CLMN_UserID = "UserID";
        private const string CLMN_ImageUrl = "ImageUrl";
        private const string CLMN_Role = "Role";

        #endregion

        public LoginBO AuthenticateUser(LoginBO objLogin)
        {
            try
            {
                using (SqlConnection connection = Connection)
                {
                    using (SqlCommand cmd = new SqlCommand("AuthenticateUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("Username", objLogin.Username);
                        cmd.Parameters.AddWithValue("Password", objLogin.Password);
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            objLogin = InflateAuthentication(reader);

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return objLogin;
        }
        private LoginBO InflateAuthentication(IDataReader dataReader)
        {
            LoginBO obj = new LoginBO();
            while (dataReader.Read())
            {
                obj.UserID = Convert.ToString(dataReader[CLMN_UserID]);
                obj.Username = Convert.ToString(dataReader[CLMN_Username]);
                obj.ImageUrl = Convert.ToString(dataReader[CLMN_ImageUrl]);
                obj.Role = Convert.ToString(dataReader[CLMN_Role]);
            }

            return obj;
        }
    }
}
