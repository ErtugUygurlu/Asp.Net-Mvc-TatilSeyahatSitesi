using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }

        BlogYorum by= new BlogYorum();
        public ActionResult BlogDetay(int id)
        {

            //var blogbul = c.Blogs.Where(w => w.ID == id).ToList();
            by.Deger1=c.Blogs.Where(w=>w.ID==id).ToList();
            return View(by);
        }
    }
}