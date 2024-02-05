using System.Data.SqlClient;

namespace CRUD.Models
{
    public class UpdateDeptClass2
    {
        public void UpdateDeptMeth(string id,string name)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "update dept_mast set dept_desc ='" + name + "' where dept_id='" + id + "'";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.ExecuteReader();
        }
    }
}
