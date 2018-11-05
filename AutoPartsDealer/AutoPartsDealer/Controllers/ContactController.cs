using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoPartsDealer.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact(int ID = 0)
        {
            ViewBag.Message = "Your contact page.";
            
            return View("../Home/Contact");
        }
    }
}