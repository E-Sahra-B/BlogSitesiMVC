using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Writer.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        private readonly IUnitOfWork u;
        public CategoryListDashboard(IUnitOfWork _service)
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
