using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MongoDb
{
    public class MongoAboutRepository : IAboutDal
    {
        private static List<About> abouts;
        public MongoAboutRepository()
        {
            if (abouts == null || abouts.Count == 0)
                abouts = new List<About>
                {
                    new About{
                        AboutID = 1,
                        AboutDetails1 = "Hello This is come from MongoDB",
                        AboutDetails2 = "Vallah billah mongodan, aha dayıya sor",
                        AboutStatus = true
                    }
                };
        }
        public void Insert(About t)
        {
            t.AboutID = abouts.Last().AboutID + 1;
            abouts.Add(t);
        }

        public void Delete(About t)
        {
            abouts.Remove(t);
        }

        public void Update(About t)
        {
            abouts.RemoveAll(x => x.AboutID == t.AboutID);
            abouts.Add(t);
        }

        public List<About> GetListAll()
        {
            return abouts;
        }

        public About GetByID(int id)
        {
            return abouts.FirstOrDefault(x => x.AboutID == id);
        }

        public About GetByFilter(Expression<Func<About, bool>> filter = null)
        {
            return abouts.AsQueryable().FirstOrDefault(filter);
        }

        public List<About> GetListAll(Expression<Func<About, bool>> filter)
        {
            return abouts.AsQueryable().Where(filter).ToList();
        }

        public int GetCount(Expression<Func<About, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
