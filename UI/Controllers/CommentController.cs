using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UI.Controllers
{
    public class CommentController : UserController
    {
        private readonly IUnitOfWork u;
        public CommentController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment(int id)
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            u.Comment.TAdd(p);
            u.SaveChanges();
            var id = p.BlogID;
            return RedirectToAction("BlogReadAll", "Blog",new { id});
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values= u.Comment.GetList(id);
            return PartialView(values);
        }
    }
}