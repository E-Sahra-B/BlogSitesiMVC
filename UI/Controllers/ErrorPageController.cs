using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ErrorPageController : UserController
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
