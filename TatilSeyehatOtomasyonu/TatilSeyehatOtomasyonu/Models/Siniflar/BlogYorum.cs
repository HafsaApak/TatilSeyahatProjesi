using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyehatOtomasyonu.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } //IEnumerable ile bir view içerisinde birden fazla tablodan
                                                      //değer çekebilicez 
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}