using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        private readonly IUnitOfWork u;
        public CategoryList(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var values = u.Category.GetList();
            return View(values);
        }
    }
}

