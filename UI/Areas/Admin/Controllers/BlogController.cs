using Business.UnitOfWork;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using X.PagedList;

namespace UI.Areas.Admin.Controllers
{
    public class BlogController : AdminBaseController
    {
        private readonly IUnitOfWork u;
        public BlogController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index(int page=1)
        {
            var values = u.Blog.GetBlogListWithCategory().ToPagedList(page, 5);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in u.Category.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator cv = new BlogValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                u.Blog.TAdd(p);
                u.SaveChanges();

                TempData["mesaj"] = "Eklendi";
                return RedirectToAction("Index", "Blog", "Admin");
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
        public IActionResult BlogDelete(int id)
        {
            var value = u.Blog.GetByID(id);
            u.Blog.TDelete(value);
            u.SaveChanges();
            Thread.Sleep(2000);
            TempData["mesaj"] = "Silindi";
            return RedirectToAction("Index", "Blog", "Admin");
        }
    }
}
