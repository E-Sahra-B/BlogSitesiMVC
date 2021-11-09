using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.Controllers
{
    public class DashboardController : WriterBaseController
    {
        public IActionResult Index()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            ViewBag.ToplamBlogSayisi = blogManager.GetList().Count();
            ViewBag.YazarBlogSayisi = blogManager.GetBlogListByWriter(1).Count();
            ViewBag.KategoriSayisi = categoryManager.GetList().Count();
            return View();
        }
    }
}
