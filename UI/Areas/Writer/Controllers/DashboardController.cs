 using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.Controllers
{
    public class DashboardController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        public DashboardController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            ViewBag.ToplamBlogSayisi = u.Blog.GetList().Count();
            var username = User.Identity.Name;
            var mail = u.User.TGetByFilter(x=> x.UserName==username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == mail).WriterID;
            ViewBag.YazarBlogSayisi = u.Blog.GetBlogListByWriter(writerid).Count();
            ViewBag.KategoriSayisi = u.Category.GetList().Count();
            return View();
        }
    }
}