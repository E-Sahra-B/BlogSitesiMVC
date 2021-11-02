using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        //public void Add(Writer writer)
        //{
        //    _writerDal.Insert(writer);
        //}
        public Writer GetByID(int id)
        {
            return _writerDal.GetByID(id);
        }
        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }
        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }
        public void TDelete(Writer t)
        {
            _writerDal.Delete(t);
        }
        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}
