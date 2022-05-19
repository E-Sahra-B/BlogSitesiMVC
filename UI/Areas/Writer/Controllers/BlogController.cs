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

namespace UI.Areas.Writer.Controllers
{
    public class BlogController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        public BlogController(IUnitOfWork _service)
        {
            u = _service;
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
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                var username = User.Identity.Name;
                var usermail=  u.User.TGetByFilter(x => x.UserName == username).Email;
                var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
                //var values = wm.GetWriterById(writerid);
                p.WriterID = writerid;
                u.Blog.TAdd(p);
                u.SaveChanges();
                return RedirectToAction("BlogListByWriter", "Blog","Writer");
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
        public IActionResult BlogEdit(int id)
        {
            var blogvalue = u.Blog.GetByID(id);
            List<SelectListItem> categoryValues = (from x in u.Category.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;

            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult BlogEdit(Blog p)
        {
            var username = User.Identity.Name;
            var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            p.WriterID = writerid;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            p.BlogStatus = true;
            u.Blog.TUpdate(p);
            u.SaveChanges();
            return RedirectToAction("BlogListByWriter", "Blog", "Writer");
        }
        public IActionResult BlogListByWriter()
        {
            var username = User.Identity.Name;
            var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            var values = u.Blog.GetListWithCategoryByWriterBM(writerid);
            return View(values);
        }
        public IActionResult BlogDelete(int id)
        {
            var blogvalue = u.Blog.GetByID(id);
            u.Blog.TDelete(blogvalue);
            Thread.Sleep(2000);
            return RedirectToAction("BlogListByWriter", "Blog", "Writer");
        }
        public IActionResult ChangeStatusBlog(int id)
        {
            var blogValue = u.Blog.GetByID(id);
            if (blogValue.BlogStatus)
            {
                blogValue.BlogStatus = false;
            }
            else
            {
                blogValue.BlogStatus = true;
            }
            u.Blog.TUpdate(blogValue);
            Thread.Sleep(2000);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
