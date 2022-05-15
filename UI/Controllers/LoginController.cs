using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : UserController
    {
        private readonly IUnitOfWork u;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(IUnitOfWork _service, SignInManager<AppUser> signInManager = null)
        {
            u = _service;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel appUser)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.Password, appUser.IsPersistent, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Writer", new { Area = "Writer" });
                }
                else
                {
                    TempData["ErrorMessage"] = "Kullanıcı adınız veya parolanız hatalı lütfen tekrar deneyiniz.";
                    return View(appUser);
                }
            }
            return View(appUser);
        }
        #region eskiLogin
        //public async Task<IActionResult> Index(Writer p)
        //{
        //    var datavalue = u.Writer.TGetByFilter(x => x.WriterMail == p.WriterMail &&
        //    x.WriterPassword == p.WriterPassword);
        //    if (datavalue != null)
        //    {
        //        //   HttpContext.Session.SetString("username", p.WriterMail);
        //        //   return RedirectToAction("Index", "Writer");
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,p.WriterMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "a");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        //return RedirectToAction("Index", "Dashboard", new { Area="Writer"});
        //        return RedirectToAction("Index", "Writer", new { Area = "Writer" });
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index");
        //    }
        //} 
        #endregion
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Blog");
        }
    }
}
