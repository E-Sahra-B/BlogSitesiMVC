using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
