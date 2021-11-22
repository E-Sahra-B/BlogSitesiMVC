using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace UI.Areas.Writer.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            var values = wm.GetWriterById(writerid);
            return View(values);
        }
    }
}
