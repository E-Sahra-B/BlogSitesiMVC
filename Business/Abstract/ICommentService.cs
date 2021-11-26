using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetList(int id);
    }
}
