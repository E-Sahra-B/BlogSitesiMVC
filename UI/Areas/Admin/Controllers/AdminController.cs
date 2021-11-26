using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class AdminController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public AdminController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
