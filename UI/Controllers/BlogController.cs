using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class BlogController : UserController
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
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = u.Blog.GetBlogByID(id);
            return View(values);
        }
    }
}
