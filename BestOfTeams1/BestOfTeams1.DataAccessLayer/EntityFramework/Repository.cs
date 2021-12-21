using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.DataAccessLayer.EntityFramework
{
    public  class Repository<T>:RepositoryBase where T:class
    {
        BestOfTeamsContext db;
        DbSet<T> objSet;
        public Repository()
        {
            db = RepositoryBase.CreateContext();
            objSet = db.Set<T>();
        }
        public List<T> List()
        {
            return objSet.ToList();
        }
        public List<T> List(Expression<Func<T, bool>> result)
        {
            return objSet.Where(result).ToList();
        }
        public int Insert(T obj)
        {
            objSet.Add(obj);
            return Save();
        }
        private int Save()
        {
            return db.SaveChanges();
        }
        public int Update(T obj)
        {
            
            return Save();
        }
        public int Remove(T obj)
        {
            objSet.Remove(obj);
            return Save();
        }
        public T Find(Expression<Func<T, bool>> result)
        {
            return objSet.FirstOrDefault(result);
        }
    }
}
