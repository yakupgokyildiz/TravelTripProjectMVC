using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Siniflar;

namespace TravelTripProjectMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MyContext myContext = new MyContext();
        public ActionResult Index()
        {
            var degerler = myContext.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = myContext.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = myContext.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler);
        }
    }
}