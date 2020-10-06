using DreamSchool.BO.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.Class
{
    public class SectionDA : BaseDA
    {
        public int SaveSection(SectionBO objSectionBO)
        {
            int result = 0;
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_SaveSection", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id", objSectionBO.Id);
                    cmd.Parameters.AddWithValue("SectionName", objSectionBO.SectionName);
                    cmd.Parameters.AddWithValue("Description", objSectionBO.Description);
                    cmd.Parameters.AddWithValue("Class", objSectionBO.Class);
                    cmd.Parameters.AddWithValue("ClassTeacher", objSectionBO.ClassTeacher);
                    cmd.Parameters.AddWithValue("RoomName", objSectionBO.RoomName);
                    cmd.Parameters.AddWithValue("BatchStartYear", objSectionBO.BatchStartYear);
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

        public List<SectionBO> GetSections()
        {
            List<SectionBO> listSections = new List<SectionBO>();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetSections", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    listSections = Common.ConvertDataTable<SectionBO>(ds.Tables[0]);
                    connection.Close();
                }
            }
            return listSections;
        }

        public SectionBO GetSectionById(string id)
        {
            SectionBO objSection = new SectionBO();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetSectionById", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    objSection = Common.GetItem<SectionBO>(ds.Tables[0].Rows[0]);
                    connection.Close();
                }
            }
            return objSection;
        }
    }
}
