using System.Data.SqlClient;

namespace CRUD.Models
{
    public class InsertLocnClass
    {
        public void  InsertLocnMeth(string id,string name)
        {
            string connstr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string strquery="insert into locn_mast values('"+id+"','"+name+"')";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            cmd.ExecuteReader();
        }
    }
}
