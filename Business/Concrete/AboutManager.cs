using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public partial class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal; 
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public About GetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }
        public int GetCount(Expression<Func<About, bool>> filter = null)
        {
            return _aboutDal.GetCount(filter);
        }
        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }
        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }
        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
