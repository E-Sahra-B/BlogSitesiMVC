using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetBlogByID(int id);
        List<Blog> GetListWithCategoryByWriterBM(int id);
        List<Blog> GetLast3Blog();
        List<Blog> GetListTitleWithExcel();
        Blog TGetByFilter(Expression<Func<Blog, bool>> filter);
    }
}
