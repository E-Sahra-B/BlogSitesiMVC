using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.Controllers
{
    public class MessageController : WriterBaseController
    {
        Message2Manager mn = new Message2Manager(new EfMessage2Repository());
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult InBox()
        {
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            ViewBag.mesajsayisi = mn.GetInboxListByWriter(writerid).Count();
            var values = mn.GetInboxListByWriter(writerid);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = mn.GetByID(id);
            return View(value);
        }
    }
}
