using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
  public  class Blog
    {
        [Key]// bu birincil anatra olmasını sağlıyor hangi sutunun olacağını belirlemek gelir 
        public int BlogID { get; set; }

        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string BlogThumbnailImage { get; set; }//blogun küçük resmi 

        public string BlogImage { get; set; }//blogun büyük resmi

        public DateTime BlogCreateDate { get; set; }

        public bool BlogStatus { get; set; }

        public int CategoryID { get; set; }// burası ıd yi tutacak ev categoriid si ile aynı isimde olacak 

        public Category Category { get; set; } // ilşiki hazır bu halde categori sonsuz blog birincil 

        public List<Comment> comments { get; set; } //list şeklinde tulacak list olanlar sonsuz olur 


    }
}
