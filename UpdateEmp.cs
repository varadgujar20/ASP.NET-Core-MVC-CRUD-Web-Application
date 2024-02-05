using System.Data.SqlClient;
namespace CRUD.Models
{
    public class UpdateEmp
    {

        public SqlDataReader GetConnect()
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = @"select e.emp_id,e.emp_name,e.salary,d.dept_desc,l.locn_desc,e2.emp_name as Manager,
	                            e.locn_id,e.dept_id,e.rep_to
	                            from emp_mast e inner join dept_mast d
	                            on e.dept_id=d.dept_id
	                            inner join locn_mast l
	                            on e.locn_id=l.locn_id
	                            left outer join emp_mast e2
	                            on e.rep_to=e2.emp_id";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();

        }

        public SqlDataReader UpdateEmpp(string emp_name, int emp_id, int locn_id, int dept_id, decimal salary, string rep_to)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = @"update emp_mast set emp_name = '" + emp_name + "' , salary = '" + salary + "', locn_id = '" + locn_id + "' ,dept_id = '" + dept_id + "' ,rep_to = '" + rep_to + " 'where emp_id ='" + emp_id + "'";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }


    }
}
