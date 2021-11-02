using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.Controllers
{
    [AllowAnonymous]
    public class DashboardController : WriterBaseController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
