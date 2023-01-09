using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyehatOtomasyonu.Models.Siniflar;

namespace TatilSeyehatOtomasyonu.Controllers
{
    public class AboutController : Controller
    {
        //get:about
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}