using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class MessageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
