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
        BlogYorum blogYorum = new BlogYorum();
        MyContext myContext = new MyContext();
        // GET: Blog
        public ActionResult Index()
        {
            //var degerler = myContext.Blogs.ToList();
            blogYorum.Deger1 = myContext.Blogs.ToList();
            blogYorum.Deger3 = myContext.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogYorum);
        }
       
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = myContext.Blogs.Where(i => i.ID == id).ToList();
            blogYorum.Deger1 = myContext.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = myContext.Yorumlars.Where(x => x.ID == id).ToList();
            return View(blogYorum);
        }
    }
}