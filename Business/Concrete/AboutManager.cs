using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public About GetByID(int id)
        {
            return _aboutDal.GetByID(id);
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
