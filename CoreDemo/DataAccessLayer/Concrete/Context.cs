using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext // kalıtım yaptık DbContext miras oldu 
                                     //DbContext aktifleşmesi içic ctrl+nokta yap 
                                     //EntityFrameworkCore paketinin yüklü olması lazım 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //OnConfiguring bağlantı sınıfını tanımlamaya yarar 
            //optionsBuilder bu paremetre ile de cağırılır
            optionsBuilder.UseSqlServer("server=DESKTOP-O9RRR03;database=coreblog;integrated security=true;");

        }

        //proplar
        public DbSet<About> Abouts  {get;set;}// dataAccesslayer katmanında entitylayer katmanını referans olarak eklediğimiz için  geldi bu entitylayerdekiler 
        //ilk başta ctrl+nokta ile aktifleştitin tamamdır devam et 

        public DbSet<Blog> Blogs { get; set; }//referans ile erişiliyorsa o bilgilere dbset ile propertyin veri türü tanımlanır 

        public DbSet<Category> categories { get; set; }//s takısını sakın unutma 

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> contacts { get; set; }

        public DbSet<Writer> writers  { get; set; }

    }
}
