using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }
        //public void Add(NewsLetter newsLetter)
        //{
        //    _newsLetterDal.Insert(newsLetter);
        //}
        public NewsLetter GetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
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
