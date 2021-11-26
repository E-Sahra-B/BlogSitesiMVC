using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

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
