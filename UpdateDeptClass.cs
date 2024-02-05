using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUD.Models
{
    public class UpdateDeptClass
    {
        public SqlDataReader UpdateDeptMeth(string id)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "select * from dept_mast where dept_id='" + id + "'";
            SqlCommand cmd = new SqlCommand(strquery, conn);

            return cmd.ExecuteReader();
        }
    }
}
