using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Areas.Admin.Controllers
{
    public class WidgetController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
