
using DreamSchool.BO.DomainModels.MasterWebsite;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DreamSchool.DA.MasterWebsite
{
    public class EventsDA : BaseDA
    {
        public List<EventsBO> GetEvents()
        {
            List<EventsBO> listEventses = new List<EventsBO>();
            using (SqlConnection connection = Connection)
            {
                using (SqlCommand cmd = new SqlCommand("USP_GetEvents", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("ItemTypeID", ItemTypeID);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    listEventses = Common.ConvertDataTable<EventsBO>(ds.Tables[0]);
                    connection.Close();
                }
            }
            return listEventses;
        }
    }
}
