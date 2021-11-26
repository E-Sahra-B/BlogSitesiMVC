using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class WriterController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public WriterController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            var values = u.Writer.GetList();
            return View(values);
        }
    }
}
