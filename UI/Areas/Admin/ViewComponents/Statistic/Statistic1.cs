using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Xml.Linq;

namespace UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        private readonly IUnitOfWork u;
        public Statistic1(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = u.Blog.GetCount();
            ViewBag.v2 = u.Message2.GetCount();
            ViewBag.v3 = u.Comment.GetCount();
            ViewBag.havaDurumu = WeatherApi().Value;

            return View();
        }
        private XAttribute WeatherApi(string city = "istanbul")
        {
            string apiKey = "387fdb4c7c24686fc26d09791f00bd89";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q="+city+ "&mode=xml&lang=tr&units=metric&appid="+apiKey;
            XDocument document = XDocument.Load(connection);
            return document.Descendants("temperature").ElementAt(0).Attribute("value");
        }
    }
}