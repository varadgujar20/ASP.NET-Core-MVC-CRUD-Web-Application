using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace CRUD.Controllers
{
    public class InsertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult InsertEmpClass()
        {
            //ViewBag.emp_id = emp_id;
            //ViewBag.emp_name = emp_name;
            //ViewBag.salary = salary;
            ViewEmp ue = new ViewEmp();
            SqlDataReader rdrloc = ue.locdiplay();
            ViewBag.rdrloc = rdrloc;
            SqlDataReader rdrdept = ue.departdiplay();
            ViewBag.rdrdept = rdrdept;
            SqlDataReader rdrrept = ue.ViewRepTo();
            ViewBag.rdrrept = rdrrept;
            //ue.InsertEmpMeth(emp_name, emp_id, locn_id, dept_id, salary, rep_to);
            return View();
        }

        [HttpPost]
        public IActionResult InsertEmpClass(int emp_id, string emp_name, decimal salary, int locn_id, int dept_id,  int rep_to)
        {
            ViewEmp de = new ViewEmp();
            de.InsertEmpMeth(emp_id, emp_name, salary, locn_id, dept_id,  rep_to);
            return RedirectToAction("ViewEmp","View");
        }
        public IActionResult InsertLocn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertLocnC(string id,string name)
        {
            InsertLocnClass il = new InsertLocnClass();
            il.InsertLocnMeth(id, name);
            return View();
        }
        public IActionResult InsertDept()
        {

            return View();
        }
        public IActionResult InsertDept2(string id,string name)
        {
            InsertDeptClass idc = new InsertDeptClass();
            idc.InsertDeptMeth(id, name);
            return View();
        }
    }
}
