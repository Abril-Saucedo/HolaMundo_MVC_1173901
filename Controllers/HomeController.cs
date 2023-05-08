using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HolaMundo_MVC_1173901.Models;

namespace HolaMundo_MVC_1173901.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HelloWorldModel { Message = "Hola Mundo" };
            return View(model);
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