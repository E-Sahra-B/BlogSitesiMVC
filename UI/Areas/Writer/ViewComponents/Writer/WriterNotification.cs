using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        private readonly IUnitOfWork u;
        public WriterNotification(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var values = u.Notification.GetList();
            return View(values);
        }
    }
}
