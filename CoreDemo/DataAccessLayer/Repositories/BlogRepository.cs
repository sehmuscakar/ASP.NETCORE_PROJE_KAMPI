using DataAccessLayer.Abstract;// bunun eklenmesi lazım 
using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal // ilk önce using DataAccessLayer.Abstract; bunu ekledik sonra interface yi impledik 
    {

        public void AddBlog(Blog blog)
        {
            //using var c = new Context(); burda farklı bi yüntem kulanıldı 
            using var c = new Context();//using DataAccessLayer.Concrete; bunn eklenmesi lazım 
            c.Add(blog);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();//using DataAccessLayer.Concrete; bunn eklenmesi lazım 
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public Blog GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();//using DataAccessLayer.Concrete; bunn eklenmesi lazım 
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();//using DataAccessLayer.Concrete; bunn eklenmesi lazım 
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
