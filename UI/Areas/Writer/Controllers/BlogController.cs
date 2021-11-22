using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
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
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetList()
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
                var usermail = User.Identity.Name;
                var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
                //var values = wm.GetWriterById(writerid);
                p.WriterID = writerid;
                bm.TAdd(p);
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
            var blogvalue = bm.GetByID(id);
            List<SelectListItem> categoryValues = (from x in cm.GetList()
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
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            p.WriterID = writerid;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            p.BlogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter", "Blog", "Writer");
        }
        public IActionResult BlogListByWriter()
        {
            var usermail = User.Identity.Name;
            var writerid = wm.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            var values = bm.GetListWithCategoryByWriterBM(writerid);
            return View(values);
        }
        public IActionResult BlogDelete(int id)
        {
            var blogvalue = bm.GetByID(id);
            bm.TDelete(blogvalue);
            Thread.Sleep(2000);
            return RedirectToAction("BlogListByWriter", "Blog", "Writer");
        }
        public IActionResult ChangeStatusBlog(int id)
        {
            var blogValue = bm.GetByID(id);
            if (blogValue.BlogStatus)
            {
                blogValue.BlogStatus = false;
            }
            else
            {
                blogValue.BlogStatus = true;
            }
            bm.TUpdate(blogValue);
            Thread.Sleep(2000);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
