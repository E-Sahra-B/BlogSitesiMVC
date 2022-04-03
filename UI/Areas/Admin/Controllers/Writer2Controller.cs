using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using UI.Areas.Admin.Models;

namespace UI.Areas.Admin.Controllers
{
    public class Writer2Controller : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var JsonWriters = JsonConvert.SerializeObject(Writers);
            return Json(JsonWriters);
        }
        public IActionResult GetWriterByID(int writerId)
        {
            var findWriter = Writers.FirstOrDefault(x => x.Id == writerId);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterModel w)
        {
            Writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
        [HttpPost]
        public IActionResult DeleteWriter(int id)
        {
            var writer = Writers.FirstOrDefault(x => x.Id == id);
            Writers.Remove(writer);
            return Json(writer);
            //return Ok(); // Bu şekilde de döndürebilirdik.
        }
        public IActionResult UpdateWriter(WriterModel writerModel)
        {
            var writer = Writers.FirstOrDefault(x => x.Id == writerModel.Id);
            writer.Name = writerModel.Name;
            var jsonWriter = JsonConvert.SerializeObject(writerModel);
            return Json(jsonWriter);
        }
        public static List<WriterModel> Writers = new List<WriterModel>
        {
            new WriterModel
            {
                Id=1,
                Name="E."
            },
            new WriterModel
            {
                Id=2,
                Name="Sahra"
            },
            new WriterModel
            {
                Id=3,
                Name="B."
            }
        };
    }
}
