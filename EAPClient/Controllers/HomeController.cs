using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAPClient.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            service.CreateEmployee(employee);
            return RedirectToAction("ListEmployee");
        }
        public ActionResult ListEmployee(string searchString)
        {
            return View(service.ListEmployee(searchString));
        }
    }
}