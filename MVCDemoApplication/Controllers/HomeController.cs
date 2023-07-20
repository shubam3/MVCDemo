using MVCDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;
using DataLibrary.DataAccessLayer;

namespace MVCDemoApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees list";
            var data = DataLibrary.BusinessLogic.EmployeeLogicDataProcess.LoadEmployess();  //oadEmployess();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmail = row.EmailAddress
                });
            }
                return View(employees);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee sign up";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            { int records = 
           EmployeeLogicDataProcess.CreateEmployee(model.EmployeeId,model.FirstName,model.LastName,model.EmailAddress);
                return RedirectToAction("Index");
            }   

            return View();
        }
    }
}