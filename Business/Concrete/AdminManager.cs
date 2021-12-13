using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public Admin GetByID(int id)
        {
            return _adminDal.GetByID(id);
        }
        public int GetCount(Expression<Func<Admin, bool>> filter = null)
        {
            return _adminDal.GetCount(filter);
        }
        public List<Admin> GetList()
        {
            return _adminDal.GetListAll();
        }
        public void TAdd(Admin t)
        {
            _adminDal.Insert(t);       
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }
        public Admin TGetByFilter(Expression<Func<Admin, bool>> filter = null)
        {
            return _adminDal.GetByFilter(filter);
        }
        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }
    }
}