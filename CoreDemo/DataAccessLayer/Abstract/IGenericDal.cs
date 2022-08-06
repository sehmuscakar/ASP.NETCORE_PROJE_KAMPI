using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public  interface IGenericDal<T> where T:class// t entity nin karşılı olacak ,T class a ait bütün nitelikleri kullanacak dışarıdan günderdik entityi 

                                                
    {
        void Insert(T t);// T türünde entity t de paremetre dışarıdan çağırıyoruz bu enntitiyi
        void Delete(T t);

        void Update(T t);

        List<T> GetListAll();//listenin tamanını getir 

        T GetByID(int id); //ideye göre getir paremetrede id dışarıdan ıd oluyor olacak bu yaptığımız metot 






    }
}
