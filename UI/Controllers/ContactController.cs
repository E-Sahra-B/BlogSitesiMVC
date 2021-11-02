﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        
        ContactManager cm =new ContactManager(new EfContactRepository());
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
            cm.TAdd(p);

            return RedirectToAction("Index","Blog");
        }
    }
}
