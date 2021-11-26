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
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2;
            u.Comment.TAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values= u.Comment.GetList(id);
            return PartialView(values);
        }
    }
}
