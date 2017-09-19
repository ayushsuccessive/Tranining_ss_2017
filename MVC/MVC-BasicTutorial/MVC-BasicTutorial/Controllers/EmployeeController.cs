using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_BasicTutorial;
using MVC_BasicTutorial.Models;
using System.Data.Entity.Validation;
using MVC_BasicTutorial.Managers;

namespace MVC_BasicTutorial.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBContext Employeedata = new EmployeeDBContext();
        public ActionResult Index()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Index(Employee model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            EmployeeManager em = new EmployeeManager();
            em.SaveData(model);
            ModelState.Clear();
            return View();
        }
        
        public ActionResult DetailView()
        {
            var data = Employeedata.Employees;
            return View(data.ToList());
        }

        public ActionResult EditView(int Empid)
        {
            var Emp = Employeedata.Employees.Where(s=> s.EmpId == Empid).FirstOrDefault();
            //ViewData["EmployeeId"] = id;
            return View(Emp);
        }

        [HttpPost]
        public ActionResult EditView(Employee model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            EmployeeManager eem = new EmployeeManager();
            eem.EditData(model);
            return RedirectToAction("DetailView");
        }

        public ActionResult DeleteData(int Empid)
        {
            EmployeeManager eem = new EmployeeManager();
            eem.DeleteData(Empid);
            return RedirectToAction("DetailView");
        }
    }

}