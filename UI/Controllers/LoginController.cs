using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
            x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
            };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }
        //public IActionResult Index(Writer p)
        //{
        //    //Context c = new Context();
        //    //var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
        //    //x.WriterPassword == p.WriterPassword);
        //    //if (datavalue != null)
        //    //{
        //    //    HttpContext.Session.SetString("username", p.WriterMail);
        //    //    return RedirectToAction("Index", "Writer");

        //    //}
        //    //else
        //    //{
        //    //    return View();
        //    //}

        //}
    }
}
