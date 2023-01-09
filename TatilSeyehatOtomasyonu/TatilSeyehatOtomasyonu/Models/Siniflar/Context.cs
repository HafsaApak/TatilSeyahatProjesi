using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TatilSeyehatOtomasyonu.Models.Siniflar
{
    public class Context : DbContext //İlgili sınıflara ulaşabilmek için dbcontext miras alma işlemi yaptık.
    {
        public DbSet<Admin> Admins { get; set; } //Admin sınıfını kullan veritabnında ismi admins olsun
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        
    }
}