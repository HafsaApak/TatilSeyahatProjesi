using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatOtomasyonu.Models.Siniflar;
namespace TatilSeyehatOtomasyonu.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();//by adında nesne oluşturduk
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3); //take al anlamında ilk 3 tanesinin listesini al
            return View(by);
        }          
        public ActionResult BlogDetay(int id)
        {
            /*var blogbul = c.Blogs.Where(x => x.ID == id).ToList();*/ //LİNQ sorgusu oluşturduk
            //bloglar içerisinde ID ile bizim dişarıdan gönderdiğimiz Id'si eşit olanı bana gönder.
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();  
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}