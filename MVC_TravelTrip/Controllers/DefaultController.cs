using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TravelTrip.Models.Siniflar;
namespace MVC_TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            var deger = c.Blogs.Take(10).ToList();
            return View(deger);
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            //sağ tık ile view ekledik layout kullanma dedik partial olucaksın dedik sen aspx usercontrol mantığı
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {

          

            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {

            var deger = c.Blogs.Take(4).ToList();
            return PartialView(deger);
        }
    }
}