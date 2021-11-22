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
            WriterManager wm = new WriterManager(new EfWriterRepository());

            ViewBag.ToplamBlogSayisi = blogManager.GetList().Count();
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            ViewBag.YazarBlogSayisi = blogManager.GetBlogListByWriter(writerid).Count();
            ViewBag.KategoriSayisi = categoryManager.GetList().Count();
            return View();
        }
    }
}
