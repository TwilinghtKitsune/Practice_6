using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice_6.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Task_1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult View_with_layout1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult View_with_layout2()
        {
            return View();
        }
    }
}