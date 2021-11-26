using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class MessageController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public MessageController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
