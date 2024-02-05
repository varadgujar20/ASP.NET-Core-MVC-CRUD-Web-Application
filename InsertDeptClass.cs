using System.Data.SqlClient;

namespace CRUD.Models
{
    public class InsertDeptClass
    {
        public void InsertDeptMeth(string id,string name)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "insert into dept_mast values('" + id + "','" + name + "')";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.ExecuteReader();
        }
        

    }
}
