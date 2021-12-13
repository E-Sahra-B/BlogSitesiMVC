using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public Comment GetByID(int id)
        {
            return _commentDal.GetByID(id);
        }
        public int GetCount(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetCount(filter);
        }
        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogID == id);
        }
        public List<Comment> GetList()
        {
            return _commentDal.GetListAll();
        }
        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }
        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }
        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
