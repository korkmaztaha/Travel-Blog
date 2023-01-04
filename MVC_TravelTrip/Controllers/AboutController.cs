using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TravelTrip.Models.Siniflar;

namespace MVC_TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            //Context üzerinden hakkimizdas sınıfına eriştim
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}