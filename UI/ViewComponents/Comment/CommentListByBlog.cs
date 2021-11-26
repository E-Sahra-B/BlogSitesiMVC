using Business.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        private readonly IUnitOfWork u;
        public CommentListByBlog(IUnitOfWork _service)
        {
            u = _service;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = u.Comment.GetList(id);
            return View(values);
        }
    }
}
