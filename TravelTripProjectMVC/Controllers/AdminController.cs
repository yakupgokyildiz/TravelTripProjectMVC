using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Siniflar;

namespace TravelTripProjectMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: 
        MyContext myContext = new MyContext();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = myContext.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            myContext.Blogs.Add(p);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        } 

        public ActionResult BlogSil(int id)
        {
            var deger = myContext.Blogs.Find(id);
            myContext.Blogs.Remove(deger);
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BlogGetir(int id)
        {
            var deger = myContext.Blogs.Find(id);
            return View("BlogGetir", deger);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = myContext.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Aciklama = b.Aciklama;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            myContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListele()
        {
            var deger = myContext.Yorumlars.ToList();
            return View(deger);
        }

        public ActionResult YorumSil(int id)
        {
            var deger = myContext.Yorumlars.Find(id);
            myContext.Yorumlars.Remove(deger);
            myContext.SaveChanges();
            return RedirectToAction("YorumListele");
        }

        public ActionResult YorumGetir(int id)
        {
            var yrm = myContext.Yorumlars.Find(id);
            return View("YorumGetir", yrm);
        }

        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var yrmlr = myContext.Yorumlars.Find(yorumlar.ID);
            yrmlr.KullaniciAdi = yorumlar.KullaniciAdi;
            yrmlr.Mail = yorumlar.Mail;
            yrmlr.Yorum = yorumlar.Yorum;
            myContext.SaveChanges();
            return RedirectToAction("YorumListele");
        }
    }
}