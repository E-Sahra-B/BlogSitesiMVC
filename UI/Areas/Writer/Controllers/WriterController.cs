using Business.UnitOfWork;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using UI.Areas.Writer.Models;

namespace UI.Areas.Writer.Controllers
{
    public class WriterController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        private readonly UserManager<AppUser> _userManager;
        public WriterController(IUnitOfWork _service, UserManager<AppUser> userManager)
        {
            u = _service;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var mail = u.User.TGetByFilter(x => x.UserName == username).Email;
            ViewBag.yazarmail = mail;
            ViewBag.yazarismi = username;
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
            var username = User.Identity.Name;
            //var mail = u.User.TGetByFilter(x => x.UserName == username).Email;
            //ViewBag.yazarmail = mail;
           
            ViewBag.obama = username;
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            #region eski
            //var username = User.Identity.Name;
            //var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            //var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            //var wv = u.Writer.GetByID(writerid);
            //return View(wv);
            #endregion            
            var writer = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = writer.Email;
            model.namesurname = writer.NameSurname;
            model.username = writer.UserName;
            model.imageurl = writer.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            #region eski
            //WriterValidator wl = new WriterValidator();
            //ValidationResult results=wl.Validate(p);
            //if (results.IsValid)
            //{
            //    u.Writer.TUpdate(p);
            //    return RedirectToAction("Index", "Dashboard", "Writer");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();

            #endregion            
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.ImageUrl = model.imageurl;
            values.Email = model.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard", "Writer");
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
            u.Writer.TAdd(w);
            return RedirectToAction("Index", "Dashboard", "Writer");
        }
    }
}