using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public CategoryController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult CategoryList()
        {
            var values = u.Category.GetList();
            return View(values);
        }
    }
}
