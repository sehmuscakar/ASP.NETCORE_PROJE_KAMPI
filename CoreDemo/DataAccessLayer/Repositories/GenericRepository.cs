using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
  public  class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();//tanımladığın sınıf hangi klasördeys onu entity sini tanımlaman lazım kütüphane olarak 
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();//tanımladığın sınıf hangi klasördeyse onu entity sini tanımlaman lazım kütüphane olarak 
            return c.Set<T>().Find(id);// generic repository yaklaşımı böyle 
        }

        public List<T> GetListAll()//tüm listeyi geri döndür 
        {
            using var c = new Context();//tanımladığın sınıf hangi klasördeys onu entity sini tanımlaman lazım kütüphane olarak 
            return c.Set<T>().ToList();//burda içerde entity olmadığı için dışarıdan aldığımız için set ile dışarıdan aldık entityi 

        }

        public void Insert(T t)
        {
            using var c = new Context();//tanımladığın sınıf hangi klasördeys onu entity sini tanımlaman lazım kütüphane olarak 
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();//tanımladığın sınıf hangi klasördeys onu entity sini tanımlaman lazım kütüphane olarak 
            c.Update(t);
            c.SaveChanges();
        }
    }
}
