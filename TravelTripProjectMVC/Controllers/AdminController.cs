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
    }
}