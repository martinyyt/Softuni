using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoPartsDealer.Controllers
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

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Location()
        {
            ViewBag.Message = "Къде се намираме?";

            return View();
        }

        public ActionResult Work()
        {
            ViewBag.Message = "Свободни позиции:";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Ние сме дистрибутори на следните марки:";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Какво ново?";

            return View();
        }
    }
}