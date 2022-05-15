using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IUserService:IGenericService<AppUser>
    {
        List<AppUser> GetWriterById(int id);
        AppUser TGetByFilter(Expression<Func<AppUser, bool>> filter);
        List<AppUser> GetAll(string email);
    }
}