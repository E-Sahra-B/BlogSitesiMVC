using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Admin.Controllers
{
    public class WriterController : AdminBaseController
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            var values = wm.GetList();
            return View(values);
        }
    }
}
