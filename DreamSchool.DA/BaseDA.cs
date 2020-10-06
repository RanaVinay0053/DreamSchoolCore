using System.Configuration;
using System.Data.SqlClient;

namespace DreamSchool.DA
{
    public class BaseDA
    {
        public SqlConnection con = new SqlConnection();
        /// <summary>
        /// SqlCommand instance accessible through derived class only not further
        /// </summary>
        protected SqlCommand sqlCommand;

        /// <summary>
        /// SqlDataAdapter instance accessible through derived class only not further
        /// </summary>
        protected SqlDataAdapter sqlDataAdapter;

        /// <summary>
        /// SqlParameter instance accessible through derived class only not further
        /// </summary>
        protected SqlParameter[] sqlParameter;

        /// <summary>
        /// Connect Constructor Returns SqlConnection Object
        /// </summary>
        SqlConnectionStringBuilder ConnectionBuilder = new SqlConnectionStringBuilder();

        public SqlConnection Connection
        {
            get
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-SN4873ES\\SQLEXPRESS;Initial Catalog=SchoolApp;Integrated Security=True");
                con.ConnectionString = "Data Source=LAPTOP-SN4873ES\\SQLEXPRESS;Initial Catalog=SchoolApp;Integrated Security=True";
                return con;
            }
        }
    }
}
