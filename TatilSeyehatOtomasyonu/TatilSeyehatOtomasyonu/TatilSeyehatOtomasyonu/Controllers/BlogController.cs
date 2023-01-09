﻿using System;
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
        public ActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        public ActionResult BlogDetay(int id)
        {
            return View();
        }
    }
}