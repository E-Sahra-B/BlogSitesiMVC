using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class NotificationController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public NotificationController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult NotificationList()
        {
            var values = u.Notification.GetList();
            return View(values);
        }
    }
}
