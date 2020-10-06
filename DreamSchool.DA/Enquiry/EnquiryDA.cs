using DreamSchool.BO.Enquiry;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.Enquiry
{
    public class EnquiryDA : BaseDA
    {
        public int SaveEnquiry(EnquiryBO objEnquiryBO)
        {
            int result = 0;
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_SaveEnquiry", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id", objEnquiryBO.Id);
                    cmd.Parameters.AddWithValue("Name", objEnquiryBO.Name);
                    cmd.Parameters.AddWithValue("FatherName", objEnquiryBO.FatherName);
                    cmd.Parameters.AddWithValue("Address", objEnquiryBO.Address);
                    cmd.Parameters.AddWithValue("Email", objEnquiryBO.Email);
                    cmd.Parameters.AddWithValue("PhoneNumber", objEnquiryBO.PhoneNumber);
                    cmd.Parameters.AddWithValue("TokenNumber", objEnquiryBO.TokenNumber);
                    cmd.Parameters.AddWithValue("ClassType", objEnquiryBO.ClassType);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    result = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    connection.Close();
                }
            }
            return result;
        }
        
        public EnquiryBO GetEnquiryByToken(string token)
        {
            EnquiryBO objEnquiry = new EnquiryBO();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetEnquiryByToken", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("token", token);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    objEnquiry = Common.GetItem<EnquiryBO>(ds.Tables[0].Rows[0]);
                    connection.Close();
                }
            }
            return objEnquiry;
        }
    }
}
