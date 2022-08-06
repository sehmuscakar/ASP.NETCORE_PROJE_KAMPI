using EntityLayer.concrete;// bu eklenedi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
 public    interface ICategoryDal:IGenericDal<Category> //yeni yorum IGenericdal üzerinden zaten aşahıdaki metotlar olduğu için yorum yaptım category dışardan gelecek 
        //access modify olması lazım yani public 
    {
      /*  List<Category> ListAllCategory();  //buna entity vermen lazım üzerine gel bunun EntityLayer.concrete olduğu kısma tıkla olacak 

        void AddCategory(Category category);//crud operasyonlarından ekleme paremetreinin türü Category paremetrenin ismi category 

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);

        Category GetById(int id);// id ye göre veri getir işte metodun türü Category 
      */


    }
}
