using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Admin.ViewComponents.Statistic
{
    public partial class Statistic2 : ViewComponent
    {
        private readonly IUnitOfWork u;
        public Statistic2(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = u.Blog.GetList().OrderByDescending(x => x.BlogID).Select(y => y.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.v2 = u.Comment.GetCount();
            return View();
        }
    }
}
