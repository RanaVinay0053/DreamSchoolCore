using DreamSchool.BO.DomainModels.MasterWebsite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DreamSchool.DA.MasterWebsite
{
 public   class NoticeDA : BaseDA
    {
        public List<NoticeBO> GetNotices()
        {
            List<NoticeBO> listNotices = new List<NoticeBO>();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetNotice", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("ItemTypeID", ItemTypeID);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    listNotices = Common.ConvertDataTable<NoticeBO>(ds.Tables[0]);
                    connection.Close();
                }
            }
            return listNotices;
        }
    }
}

