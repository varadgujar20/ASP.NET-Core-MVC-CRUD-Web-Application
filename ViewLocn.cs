using System.Data.SqlClient;
namespace CRUD.Models
{
    public class ViewLocn
    {
        public SqlDataReader ViewConnect()
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "select * from locn_mast";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }
        public void locndelete(int locn_id)
        {
            string constr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string strrQuery = "Delete from  locn_mast where locn_id = '" + locn_id + "'";
            SqlCommand cmd = new SqlCommand(strrQuery, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
