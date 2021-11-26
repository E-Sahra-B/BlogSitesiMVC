using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UI.Controllers
{
    public class ContactController : UserController
    {
        private readonly IUnitOfWork u;
        public ContactController(IUnitOfWork _service)
        {
            u = _service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            u.Contact.TAdd(p);

            return RedirectToAction("Index","Blog");
        }
    }
}
