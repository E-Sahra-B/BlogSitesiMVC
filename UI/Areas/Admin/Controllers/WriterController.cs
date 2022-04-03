using Business.UnitOfWork;
using Business.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using X.PagedList;

namespace UI.Areas.Admin.Controllers
{
    public class WriterController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public WriterController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index(int page=1)
        {
            var values = u.Writer.GetList().ToPagedList(page, 5);
            return View(values);
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(Entity.Concrete.Writer p)
        {
            WriterValidator cv = new WriterValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                u.Writer.TAdd(p);
                u.SaveChanges();

                TempData["mesaj"] = "Eklendi";
                return RedirectToAction("Index", "Writer", "Admin");
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
        public IActionResult WriterDelete(int id)
        {
            var value = u.Writer.GetByID(id);
            u.Writer.TDelete(value);
            u.SaveChanges();
            Thread.Sleep(2000);
            TempData["mesaj"] = "Silindi";
            return RedirectToAction("Index", "Writer", "Admin");
        }
    }
}