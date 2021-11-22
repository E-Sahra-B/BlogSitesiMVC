using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Entity.Concrete;
using UI.Areas.Writer.Models;
using System.IO;
using System;
using System.Security.Claims;

namespace UI.Areas.Writer.Controllers
{
    public class WriterController : WriterBaseController
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var mail = User.Identity.Name;
            ViewBag.yazarmail = mail;
            ViewBag.yazarismi = wm.TGetByFilter(x => x.WriterMail == mail).WriterName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            var mail = User.Identity.Name;
            ViewBag.yazarmail = mail;
            ViewBag.yazarismi = wm.TGetByFilter(x => x.WriterMail == mail).WriterName;
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            var wv = wm.GetByID(writerid);
            return View(wv);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Entity.Concrete.Writer p)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult results=wl.Validate(p);
            if (results.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard", "Writer");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Entity.Concrete.Writer w = new Entity.Concrete.Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newImageName;
            }
            //AddProfileImage.ImageAdd(imageFile, out string imageName);
            //Entity.Concrete.Writer.WriterImage = imageName;
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard", "Writer");
        }
    }
}
