using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM_MVC.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace HRM_MVC.Controllers {
    public class HomeController : Controller {
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

        // GET DATA METHOD
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
        }

        // POST DATA METHOD (from view to
        // Validate data on backend and redirect to Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {

            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(model.EmployeeId,
                     model.FirstName,
                     model.LastName,
                     model.EmailAdress);

                return RedirectToAction("Index");

            }
            //ViewBag.Message = "Employee Sign Up";

            return View();
        }
    }
}