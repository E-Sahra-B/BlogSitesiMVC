using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.Controllers
{
    public class MessageController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        public MessageController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            ViewBag.mesajsayisi = u.Message2.GetInboxListByWriter(writerid).Count();
            var values = u.Message2.GetInboxListByWriter(writerid);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = u.Message2.GetByID(id);
            return View(value);
        }
    }
}
