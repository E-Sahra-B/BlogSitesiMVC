using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMessage2Service : IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
    }
}
