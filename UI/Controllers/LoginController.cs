using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class LoginController : UserController
    {
        private readonly IUnitOfWork u;
        public LoginController(IUnitOfWork _service)
        {
            u = _service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer p)
        {
            var datavalue = u.Writer.TGetByFilter(x => x.WriterMail == p.WriterMail &&
            x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
             //   HttpContext.Session.SetString("username", p.WriterMail);
             //   return RedirectToAction("Index", "Writer");
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                //return RedirectToAction("Index", "Dashboard", new { Area="Writer"});
                return RedirectToAction("Index", "Writer", new { Area="Writer"});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Blog");
        }
    }
}
