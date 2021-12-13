using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        protected Context context;
        public GenericRepository(Context _context)
        {
            context = _context;
        }
        public void Delete(T t)
        {
            context.Remove(t);
        }
        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }
        public void Insert(T t)
        {
            context.Add(t);
        }
        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }
        public void Update(T t)
        {
            context.Update(t);
        }
        public T GetByFilter(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
                return context.Set<T>().FirstOrDefault();
            else
                return context.Set<T>().FirstOrDefault(filter);
        }
        public int GetCount(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            if (filter == null)
                return c.Set<T>().Count();
            else
                return c.Set<T>().Where(filter).Count();
        }
    }
}
