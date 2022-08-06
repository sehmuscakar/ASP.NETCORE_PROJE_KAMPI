using EntityLayer.concrete;//bu eklendi 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IBlogDal:IGenericDal<Blog>//büyle yaparak blog içirisindeki interfeaceleri içerisindeki metotları tekrar tekrar yazmaktan kurtulduk direk gernericten miras almış olduk  
    {
     /*  List<Blog> ListAllBlog();  //buna entity vermen lazım üzerine gel bunun olduğu kısma tıkla olacak 

        void AddBlog(Blog blog);//crud operasyonlarından ekleme paremetreinin türü Category paremetrenin ismi category 

        void DeleteBlog(Blog blog);

        void UpdateBlog(Blog blog);

        Blog GetById(int id);
     */
    }
}
