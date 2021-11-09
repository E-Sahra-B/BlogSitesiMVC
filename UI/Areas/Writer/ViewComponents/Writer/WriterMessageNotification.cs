using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageManager mn = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "s@hra";
            ViewBag.mesajsayisi = mn.GetInboxListByWriter(p).Count();
            var values = mn.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
