using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class WriterLoginManager : IWriterLoginService
    {
        IWriterDal _writerDal;
        public WriterLoginManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public Writer GetWriter(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}