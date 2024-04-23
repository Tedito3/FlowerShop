using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult Flowers()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Sales()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}