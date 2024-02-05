using System.Data.SqlClient;
namespace CRUD.Models
{
    public class UpdateLocn
    {
        public SqlDataReader UpdateLocnMeth(string id)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "select * from locn_mast where locn_id='"+id+"'";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }
    }
}

