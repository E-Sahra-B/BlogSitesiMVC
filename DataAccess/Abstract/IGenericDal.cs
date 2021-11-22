﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id);
        T GetByFilter(Expression<Func<T, bool>> filter = null);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
