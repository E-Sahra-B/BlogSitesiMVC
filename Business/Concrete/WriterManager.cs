﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public Writer GetByID(int id)
        {
            return _writerDal.GetByID(id);
        }
        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }
        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x=> x.WriterID==id);
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
        public Writer TGetByFilter(Expression<Func<Writer, bool>> filter)
        {
            return _writerDal.GetByFilter(filter);
        }
        public int GetCount(Expression<Func<Writer, bool>> filter = null)
        {
            return _writerDal.GetCount(filter);
        }
    }
}
