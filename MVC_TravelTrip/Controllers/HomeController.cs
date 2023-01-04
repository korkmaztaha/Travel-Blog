using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TravelTrip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          //Appstart route configten yapabilirsin
            return Redirect("/Default/Index");
       
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