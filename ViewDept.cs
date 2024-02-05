using System.Data.SqlClient;
namespace CRUD.Models
{
    public class ViewDept
    {
        public SqlDataReader ViewConnect()
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "select * from dept_mast";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }

        public void deptdelete(int dept_id)
        {
            string constr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string strrQuery = "Delete from  dept_mast where dept_id = '" + dept_id + "'";
            SqlCommand cmd = new SqlCommand(strrQuery, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
