using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using X.PagedList;

namespace UI.Areas.Admin.Controllers
{
    public class NotificationController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public NotificationController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult NotificationList(int page=1)
        {
            var values = u.Notification.GetList().ToPagedList(page, 3);
            return View(values);
        }
        public IActionResult NotificationDelete(int id)
        {
            var value = u.Notification.GetByID(id);
            u.Notification.TDelete(value);
            u.SaveChanges();
            Thread.Sleep(2000);
            TempData["mesaj"] = "Silindi";
            return RedirectToAction("NotificationList", "Notification", "Admin");
        }
    }
}
