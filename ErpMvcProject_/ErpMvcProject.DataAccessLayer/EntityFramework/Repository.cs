using ErpMvcProject.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer.EntityFramework
{
   public class Repository<T>: RepositoryBase where T:class
    {
        ErpMvcContext db;

        private DbSet<T> objSet;
        public Repository()
        {
            db = RepositoryBase.CreateContext();
            objSet = db.Set<T>();
        }
        public List<T> List()
        {
            return objSet.ToList();
        }
        public List<T> List(Expression<Func<T,bool>>Eresult)
        {

            return objSet.Where(Eresult).ToList();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public int Insert(T obj)
        {
            objSet.Add(obj);  
            return Save(); 
        }  
        public int Update(T obj)
        {
            
            return Save();  
        } 
        public int Delete(T obj)
        {
            objSet.Remove(obj);
            return Save();
        }
        public T Find(Expression<Func<T, bool>> Eresult)
        {
            return objSet.FirstOrDefault(Eresult);//FirstOrDefault : Bulduğun ilk değeri yada standart değeri olan null değer döndür.
        }
    }
}
