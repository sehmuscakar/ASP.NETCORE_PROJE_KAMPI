using DataAccessLayer.Abstract;//bu eklendi
using DataAccessLayer.Concrete;//buda eklendi 
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
  public  class CategoryRepository : ICategoryDal // bunu kullanabilmen için ctrl+. yapman lazım 
    {
        Context c = new Context();// veritabanı gerekli olduğu için bunu yaz ve ctrl+. yap aktifleşsin ,using DataAccessLayer.Concrete;


        // CategoryRepository sınıfının içinde Icategorydal daki metotları kullanmak istoyrsun miras aldın zaten bide implete etmen lazım 
        //ampüle tıkla implete interface ye tıkla metotlar gelsin 
        public void AddCategory(Category category)
        {
            c.Add(category);// paremetreyi içine ekliyoruz entity ekledik 
            c.SaveChanges();//değişikklikleri kaydediyor 
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.categories.Find(id); //idye göre bulacaz kategoriyi 
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            // burda veri türü void değil list olduğu için return olması lazım ki hata olmasın 
            return c.categories.ToList();//categories e göre listeleme yapacak 
        
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
