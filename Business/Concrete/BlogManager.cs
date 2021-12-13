using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal BlogDal)
        {
            _blogDal = BlogDal;
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBM(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }
        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }
        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
        public List<Blog> GetListTitleWithExcel()
        {
            //throw new System.NotImplementedException();
            return _blogDal.GetListTitleWithExcel();
        }
        public Blog TGetByFilter(Expression<Func<Blog, bool>> filter)
        {
            return _blogDal.GetByFilter(filter);
        }
        public int GetCount(Expression<Func<Blog, bool>> filter = null)
        {
            return _blogDal.GetCount(filter);
        }
    }
}