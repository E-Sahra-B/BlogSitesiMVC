using Entity.Concrete;
using System;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAdminService : IGenericService<Admin>
    {
        Admin TGetByFilter(Expression<Func<Admin, bool>> filter);
    }
}
