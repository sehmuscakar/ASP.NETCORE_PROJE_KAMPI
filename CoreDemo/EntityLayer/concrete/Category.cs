using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
  public   class Category
    {
        //property nasıl tanımlanır 
        //erişim belirliyici türü-Değişken türü -isim{get set  }
        [Key]
        public int CategoryID { get; set; } // prop yaz iki defa tab tuşu 

        public string  CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }// kategorileri silmek yerine aktif pasif yapacaz bunu kullanacaz

        public List<Blog> blogs { get; set; }//ilişki olacak burda blog u liste olarak tuutacak ve blog arasında ilişki olacak 

    }
}
