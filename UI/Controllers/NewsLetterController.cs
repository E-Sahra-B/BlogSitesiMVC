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
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            if (u.Newsletter.GetByMail(newsLetter.Mail) == null && newsLetter.Mail != null)
            {
                u.Newsletter.TAdd(newsLetter);
                u.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}