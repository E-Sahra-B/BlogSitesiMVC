using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UI.Models;

namespace UI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Ayşe"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Fatma"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Hayriye"
                }
            };
            return View(commentvalues);
        }
    }
}
