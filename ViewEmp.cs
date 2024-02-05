using System.Data.SqlClient;
namespace CRUD.Models
{
    public class ViewEmp
    {
        public SqlDataReader ViewConnect()
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
        public SqlDataReader ViewRepTo()
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = @"select * from emp_mast";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }
        public SqlDataReader locdiplay()
        {
            string constr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string strloc = "Select * from locn_mast";
            SqlCommand cmdloc = new SqlCommand(strloc, conn);
            return cmdloc.ExecuteReader();
        }
        public SqlDataReader departdiplay()
        {
            string constr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string strdepart = "Select * from dept_mast";
            SqlCommand cmddept = new SqlCommand(strdepart, conn);
            return cmddept.ExecuteReader();
        }

        public void empdelete(int emp_id)
        {
            string constr = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string strrQuery = "Delete from  emp_mast where emp_id = '" + emp_id + "'";
            SqlCommand cmd = new SqlCommand(strrQuery, conn);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader UpdateEmpp(string emp_name, int emp_id, int locn_id, int dept_id, decimal salary, int rep_to)
        {
            string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string strquery = @"update emp_mast set emp_name = '" + emp_name + "' , salary = '" + salary + "', locn_id = '" + locn_id + "' ,dept_id = '" + dept_id + "' ,rep_to = '" + rep_to + " 'where emp_id ='" + emp_id + "'";
            SqlCommand cmd = new SqlCommand(strquery, conn);
            return cmd.ExecuteReader();
        }

         public void InsertEmpMeth(int emp_id, string emp_name, decimal salary, int locn_id, int dept_id, int rep_to)
         {
                string strconn = "Data Source=Varad; Database=master; user id=sa; password=123;";
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                string strquery = "insert into emp_mast (emp_id,emp_name,salary,locn_id,dept_id,rep_to) values('" + emp_id + " ','" + emp_name + "','" + salary + "' ,'" + locn_id + "','" + dept_id + "','" + rep_to + "')";
                SqlCommand cmd = new SqlCommand(strquery, conn);
                cmd.ExecuteNonQuery();
         }
        
    }
}
