using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        private readonly IUnitOfWork u;
        public WriterLastBlog(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var values = u.Blog.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
