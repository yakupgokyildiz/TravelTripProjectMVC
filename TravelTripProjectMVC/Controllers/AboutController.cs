using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Siniflar;

namespace TravelTripProjectMVC.Controllers
{
    public class AboutController : Controller
    {
        MyContext myContext = new MyContext();
        // GET: About
        public ActionResult Index()
        {
            var degerler = myContext.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}