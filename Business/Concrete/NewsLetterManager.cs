using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }
        public NewsLetter GetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
        }
        public int GetCount(Expression<Func<NewsLetter, bool>> filter = null)
        {
            return _newsLetterDal.GetCount(filter);
        }
        public List<NewsLetter> GetList()
        {
            return _newsLetterDal.GetListAll();
        }
        public void TAdd(NewsLetter t)
        {
            _newsLetterDal.Insert(t);
        }
        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.Delete(t);
        }
        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
