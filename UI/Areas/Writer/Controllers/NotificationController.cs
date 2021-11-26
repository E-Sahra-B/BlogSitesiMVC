using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.Controllers
{
    public class NotificationController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        public NotificationController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var values = u.Notification.GetList();
            return View(values);
        }
    }
}
