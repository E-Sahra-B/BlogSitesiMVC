using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class NewsLetterController : UserController
    {
        private readonly IUnitOfWork u;
        public NewsLetterController(IUnitOfWork _service)
        {
            u = _service;
        }
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            u.Newsletter.TAdd(p);
            return PartialView();
        }
    }
}
