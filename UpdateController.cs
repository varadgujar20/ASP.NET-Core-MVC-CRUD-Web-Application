using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CRUD.Controllers
{
    public class UpdateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Employee()
        //{
        //    DBConnect dc = new DBConnect();
        //    SqlDataReader rdr = dc.GetConnect();
        //    ViewBag.Connect = rdr;
        //    return View("Employee");

        //}
        public IActionResult UpdateEmp(string emp_name, int emp_id, int locn_id, int dept_id, decimal salary, int rep_to)
        {
            ViewBag.emp_id = emp_id;
            ViewBag.emp_name = emp_name;
            ViewBag.salary = salary;
            ViewEmp ue = new ViewEmp();
            SqlDataReader reader = ue.locdiplay();
            SqlDataReader rdr1 = ue.departdiplay();
            SqlDataReader rdr2 = ue.ViewRepTo();
            ue.UpdateEmpp(emp_name, emp_id, locn_id, dept_id, salary, rep_to);
            ViewBag.Connect = reader;
            ViewBag.Connectt = rdr1;
            ViewBag.Connecttt = rdr2;
            return View();
        }
        

        public IActionResult UpdateLocn(string id)
        {
            UpdateLocn ul = new UpdateLocn();
            SqlDataReader reader= ul.UpdateLocnMeth(id);
            ViewBag.UpdateLocn = reader;
            return View();
        }
        [HttpPost]
        public IActionResult UpdateLocnCalc(string id,string name)
        {
            UpdateLocnCalcClass ulc = new UpdateLocnCalcClass();
            ulc.UpdateLocnCalcMeth(id,name);

            return View();
        }
        public IActionResult UpdateDept(string id)
        {
            UpdateDeptClass idc=new UpdateDeptClass();
            SqlDataReader reader= idc.UpdateDeptMeth(id);
            ViewBag.UpdateDept= reader;
            return View();
        }
        public IActionResult UpdateDept2(string id,string name)
        {
            UpdateDeptClass2 udc= new UpdateDeptClass2();
            udc.UpdateDeptMeth(id, name);
            return View();

        }

    }
}
