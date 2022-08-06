using Business_Layer.Abstract;//bunun eklmesi lazım miras için ilk önce 
using DataAccessLayer.EntityFramework;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
  public  class CategoryManager : ICategoryService//sonra iplete edilmesi lazım 
    {
        EfCategoryRepository efCategoryRepository;// EfCategoryRepository türünde  efCategoryRepository bu bişeni tanımladım 

        public CategoryManager()//ctor yaz iki tap olur //yapıcı foksiyon bu 
        {
            efCategoryRepository = new EfCategoryRepository();//yapıcı fonksiyon içine new leme yaptık

        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category); //category den gelen değeri ekle
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
