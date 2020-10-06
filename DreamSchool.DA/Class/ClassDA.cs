using DreamSchool.BO.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.Class
{
    public class ClassDA : BaseDA
    {
        public int SaveClass(ClassBO objClassBO)
        {
            int result = 0;
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_SaveClass", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id", objClassBO.Id);
                    cmd.Parameters.AddWithValue("ClassName", objClassBO.ClassName);
                    cmd.Parameters.AddWithValue("ClassType", objClassBO.ClassType);
                    cmd.Parameters.AddWithValue("NumericalValue", objClassBO.NumericalValue);
                    cmd.Parameters.AddWithValue("Fees", objClassBO.Fees);
                    cmd.Parameters.AddWithValue("LoggedInUserId", "C6868463-6968-41B4-BD59-55F50BD70F8B");
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    result = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    connection.Close();
                }
            }
            return result;
        }

        public List<ClassBO> GetClasses()
        {
            List<ClassBO> listClasses = new List<ClassBO>();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetClasses", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("ItemTypeID", ItemTypeID);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    listClasses = Common.ConvertDataTable<ClassBO>(ds.Tables[0]);
                    connection.Close();
                }
            }
            return listClasses;
        }

        public ClassBO GetClassById(string id)
        {
            ClassBO objClass = new ClassBO();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetClassById", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    objClass = Common.GetItem<ClassBO>(ds.Tables[0].Rows[0]);
                    connection.Close();
                }
            }
            return objClass;
        }
    }
}
