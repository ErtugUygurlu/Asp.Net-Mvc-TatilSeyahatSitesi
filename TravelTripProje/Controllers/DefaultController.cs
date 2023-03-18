using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c= new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();


        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(w => w.ID >= 3).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(w => w.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
    }
}