using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }
        public int GetCount(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetCount(filter);
        }
        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }
        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }
        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }
        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
