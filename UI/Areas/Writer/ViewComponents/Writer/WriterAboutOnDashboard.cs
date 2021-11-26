using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

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
            var usermail = User.Identity.Name;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            var values = u.Writer.GetWriterById(writerid);
            return View(values);
        }
    }
}
