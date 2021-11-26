using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        private readonly IUnitOfWork u;
        public BlogListDashboard(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var values = u.Blog.GetBlogListWithCategory();
            return View(values);
        }
    }
}
