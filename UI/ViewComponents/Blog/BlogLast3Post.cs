using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        private readonly IUnitOfWork u;
        public BlogLast3Post(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var values = u.Blog.GetLast3Blog();
            return View(values);
        }
    }
}
