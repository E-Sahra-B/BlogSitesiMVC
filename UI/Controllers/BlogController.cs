using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class BlogController : UserController
    {
        //IBlogService _blogService;
        //public BlogController(IBlogService blogService)
        //{
        //    _blogService = blogService;
        //}
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            //var values = _blogService.GetBlogListWithCategory();
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            //var values = _blogService.GetBlogByID(id);
            var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
