using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DreamSchool.Models;

namespace DreamSchool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Notices()
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }

        public ActionResult Scholarship()
        {
            return View();
        }

        public ActionResult Teachers()
        {
            return View();
        }

        public ActionResult ViewTeacher()
        {
            return View();
        }

        public ActionResult ViewBlog()
        {
            return View();
        }

        public ActionResult ViewCourse()
        {
            return View();
        }

        public ActionResult ViewEvent()
        {
            return View();
        }

        public ActionResult ViewNotice()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
