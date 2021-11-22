using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mn = new Message2Manager(new EfMessage2Repository());
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            int id = writerid;
            ViewBag.mesajsayisi = mn.GetInboxListByWriter(id).Count();
            var values = mn.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
