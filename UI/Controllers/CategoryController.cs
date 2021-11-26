using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CategoryController : UserController
    {
        private readonly IUnitOfWork u;
        public CategoryController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            var values = u.Category.GetList();
            return View(values);
        }
    }
}
