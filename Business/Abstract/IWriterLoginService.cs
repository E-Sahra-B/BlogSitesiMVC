using Entity.Concrete;

namespace Business.Abstract
{
    public interface IWriterLoginService 
    {
       Writer GetWriter(string username, string password);
    }
}
