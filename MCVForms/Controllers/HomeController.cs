using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVForms.Models;

namespace MCVForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
            {
          
                return View("Index");
            }
        [HttpPost]

        public ActionResult Index(StudentModel sm) 
        {
            ViewBag.Id = sm.Id;
            ViewBag.Name = sm.Name;
            ViewBag.Course = sm.courseModel.Course;
            ViewBag.Duration = sm.courseModel.Duration;
            return View("Index");
              
        }
        

        private ActionResult View(Func<ActionResult> index)
        {
            throw new NotImplementedException();
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
    }
}