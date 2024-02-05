using System.Data.SqlClient;
namespace CRUD.Models
{
    public class UpdateLocnCalcClass
    {
        public void UpdateLocnCalcMeth(string locn_id,string name)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = "update locn_mast set locn_desc='"+name+"' where locn_id='"+locn_id+"'";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.ExecuteReader();

        }
    }
}
