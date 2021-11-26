using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AboutController : UserController
    {
        private readonly IUnitOfWork u;
        public AboutController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            var values = u.About.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
