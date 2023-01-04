using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TravelTrip.Models.Siniflar;
namespace MVC_TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var d = c.Blogs.ToList();
            return View(d);
        }



        [HttpGet]
        public ActionResult yeniBlog()
        {
            //Sayfa ilk açılımca çalışıcak sayfa açılınca bir şey yapma bana sadece sayfayı dön dedik
            return View();
        }
        [HttpPost]
        public ActionResult yeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult blogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult blogGetir(int id = 0)
        {
            if (id == 0)
            {
                return View("BlogGetir");
            }
            else
            {
                var b = c.Blogs.Find(id);
                ViewBag.d = b.BlogImage;
                return View("BlogGetir", b);
            }

        }

        public ActionResult BlogGuncelle(Blog b)
        {
            if (b.ID == 0)
            {

                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    //string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Foto/" + dosyaAdi;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    b.BlogImage = "/Foto/" + dosyaAdi;
                }
                c.Blogs.Add(b);
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var blg = c.Blogs.Find(b.ID);
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    //string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Foto/" + dosyaAdi;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    blg.BlogImage = "/Foto/" + dosyaAdi;
                }
               
                blg.Aciklama = b.Aciklama;
                blg.Baslik = b.Baslik;
                //blg.BlogImage = b.BlogImage;
                blg.Tarih = b.Tarih;
                c.SaveChanges();
                return RedirectToAction("Index");
            }

          





        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult yorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);

        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullainiciAdi = y.KullainiciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}