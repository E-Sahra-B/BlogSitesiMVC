using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Areas.Admin.Models;

namespace UI.Areas.Admin.Controllers
{
    public class ChartController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            list.Add(new CategoryModel
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryModel
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new CategoryModel
            {
                categoryname = "Spor",
                categorycount = 2
            });
            list.Add(new CategoryModel
            {
                categoryname = "Sinema",
                categorycount = 5
            });

            return Json(new { jsonlist = list });
        }
    }
}
