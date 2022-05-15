using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        private readonly IUnitOfWork u;
        public WriterMessageNotification(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            int id = writerid;
            ViewBag.mesajsayisi = u.Message2.GetInboxListByWriter(id).Count();
            var values = u.Message2.GetInboxListByWriter(id);
            return View(values);
        }
    }
}