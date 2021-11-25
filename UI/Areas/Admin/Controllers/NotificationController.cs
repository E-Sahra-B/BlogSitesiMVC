using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class NotificationController : AdminBaseController
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());

        public IActionResult NotificationList()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
