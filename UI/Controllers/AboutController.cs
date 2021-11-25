using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AboutController : UserController
    {
        //IAboutService _aboutService;
        //public AboutController(IAboutService aboutService)
        //{
        //    _aboutService = aboutService;
        //}
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            //var values = _aboutService.GetList();
            var values = abm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            
            return PartialView();
        }
    }
}
