using Business.UnitOfWork;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class RegisterController : UserController
    {
        private readonly IUnitOfWork u;
        public RegisterController(IUnitOfWork _service)
        {
            u = _service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
             p.WriterStatus = true;
             p.WriterAbout = "Deneme Test";
            u.Writer.TAdd(p);
                TempData.Add("message", string.Format("KAyıt olundu"));


                return RedirectToAction("Index","Blog");
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
    }
}
