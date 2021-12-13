using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.ViewComponents.Statistic
{
    public partial class Statistic4 : ViewComponent
    {
        private readonly IUnitOfWork u;
        public Statistic4(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var value = u.Admin.TGetByFilter(x => x.AdminID == 1);
            ViewBag.v1 = value.Name;
            ViewBag.v2 = value.ImageURL;
            ViewBag.v3 = value.ShortDescription;
            return View();
        }
    }
}