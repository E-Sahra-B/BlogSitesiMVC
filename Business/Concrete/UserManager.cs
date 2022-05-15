using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public AppUser GetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public int GetCount(Expression<Func<AppUser, bool>> filter = null)
        {
            return _userDal.GetCount(filter);
        }

        public List<AppUser> GetList()
        {
            return _userDal.GetListAll();
        }

        public void TAdd(AppUser t)
        {
            _userDal.Insert(t); ;
        }

        public void TDelete(AppUser t)
        {
            _userDal.Delete(t);
        }

        public AppUser TGetByFilter(Expression<Func<AppUser, bool>> filter)
        {
            return _userDal.GetByFilter(filter);
        }

        public void TUpdate(AppUser t)
        {
            _userDal.Update(t);
        }
        public List<AppUser> GetWriterById(int id)
        {
            return _userDal.GetListAll(x => x.Id == id);
        }
        public List<AppUser> GetAll(string email)
        {
            return _userDal.GetListAll(w => w.Email == email);
        }
    }
}