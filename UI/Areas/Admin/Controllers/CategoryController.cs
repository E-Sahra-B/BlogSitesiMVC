using Business.UnitOfWork;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using X.PagedList;

namespace UI.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public CategoryController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult CategoryList(int page=1)
        {
            var values = u.Category.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                u.Category.TAdd(p);
                u.SaveChanges();

                TempData["mesaj"] = "Eklendi";
                return RedirectToAction("CategoryList", "Category", "Admin");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = u.Category.GetByID(id);
            u.Category.TDelete(value);
            u.SaveChanges();
            Thread.Sleep(2000);
            TempData["mesaj"] = "Silindi";
            return RedirectToAction("CategoryList", "Category", "Admin");
        }
    }
}
