using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Abstract
{
   public interface ICategoryService
    {
        void CategoryAdd(Category category);//Category sınıfınını aktifleşmesi için using EntityLayer.concrete; eklenmesi lazım
                                            //using EntityLayer.concrete; bunun dahil edilebilmesi için bu katmanının içine ilgili refreransların dağil edilmiş olması lazım 
                                            //EntityLayer.concrete bu katmana bağı olarak yani buradaki refreansa eklnemiş olması lazım 
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetList();//listeyi getir 

        Category GetById(int id);// dışarıdan bir id paremetresi alacaksın category sınıfından  


    }
}
