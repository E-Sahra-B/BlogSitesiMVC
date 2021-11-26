using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class BlogController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public BlogController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            var values = u.Blog.GetBlogListWithCategory();
            return View(values);
        }
    }
}
