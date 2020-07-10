using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjectMVC.Models.Siniflar;

namespace TravelTripProjectMVC.Controllers
{
    public class BlogController : Controller
    {
        MyContext myContext = new MyContext();
        // GET: Blog
        public ActionResult Index()
        {
            var degerler = myContext.Blogs.ToList();
            return View(degerler);
        }
    }
}