using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;

namespace CRUD.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewEmp(int emp_id)
        {
            ViewBag.emp_id = emp_id;
            ViewEmp ve = new ViewEmp();
            SqlDataReader reader= ve.ViewConnect();
            ViewBag.ViewConnect= reader;
            return View();
        }
        public IActionResult ViewLocn()
        {
            ViewLocn vl = new ViewLocn();
            SqlDataReader reader= vl.ViewConnect();
            ViewBag.ViewConnect= reader;
            return View();
        }
        public IActionResult ViewDept()
        {
            ViewDept vd = new ViewDept();
            SqlDataReader reader= vd.ViewConnect();
            ViewBag.ViewConnect= reader;
            return View();
        }
        public IActionResult Delete(int emp_id)
        {
            ViewEmp dc = new ViewEmp();
            dc.empdelete(emp_id);
            return RedirectToAction("ViewEmp");
        }

        public IActionResult DeptDelete(int dept_id)
        {
            ViewDept dc = new ViewDept();
            dc.deptdelete(dept_id);
            return RedirectToAction("ViewDept");
        }

        public IActionResult LocnDelete(int locn_id)
        {
            ViewLocn dc = new ViewLocn();
            dc.locndelete(locn_id);
            return RedirectToAction("ViewLocn");
        }
        
    }
}
