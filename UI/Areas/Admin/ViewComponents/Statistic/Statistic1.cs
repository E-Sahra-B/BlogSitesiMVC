using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        private readonly IUnitOfWork u;
        public Statistic1(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = u.Blog.GetCount();
            ViewBag.v2 = u.Message2.GetCount();
            ViewBag.v3 = u.Comment.GetCount();
            return View();
        }
    }
}