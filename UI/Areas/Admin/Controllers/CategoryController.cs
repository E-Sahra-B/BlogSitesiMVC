using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class CategoryController : AdminBaseController
    {
        //ICategoryService _categoryService;

        //public CategoryController(ICategoryService categoryService)
        //{
        //    _categoryService = categoryService;
        //}
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult CategoryList()
        {
            //var values = _categoryService.GetList();
            var values = cm.GetList();
            return View(values);
        }
    }
}
