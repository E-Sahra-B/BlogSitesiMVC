using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        private readonly IUnitOfWork u;
        public WriterAboutOnDashboard(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.veri = username;
            var values = u.User.GetAll(email: username);
            return View(values);
        }
    }
}
