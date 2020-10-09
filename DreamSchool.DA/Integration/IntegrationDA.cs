using DreamSchool.BO.Integration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DreamSchool.DA.Integration
{
    public class IntegrationDA : BaseDA
    {
        public DataTable Login(IntegrationBO obj)
        {

            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("AuthenticateUser", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Username", obj.Username);
                    cmd.Parameters.AddWithValue("Password", obj.password);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                   
                    DataTable ds = new DataTable();
                    adp.Fill(ds);
                    DataTable dt = ds;
                    connection.Close();
                    return dt;
                }
            }
           
            
        }

       
    }
}
