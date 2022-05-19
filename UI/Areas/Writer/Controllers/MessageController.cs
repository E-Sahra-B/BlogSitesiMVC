using Business.Abstract;
using Business.UnitOfWork;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Areas.Writer.Controllers
{
    public class MessageController : WriterBaseController
    {
        private readonly IUnitOfWork u;
        private readonly IMessage2Service _message2Service;
        private readonly IUserService _userService;
        public MessageController(IUnitOfWork _service, IMessage2Service message2Service, IUserService userService)
        {
            u = _service;
            _message2Service = message2Service;
            _userService = userService;
        }
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            ViewBag.mesajsayisi = u.Message2.GetInboxWithMessageByWriter(writerid).Count();
            var values = u.Message2.GetInboxWithMessageByWriter(writerid);
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = u.Message2.GetByID(id);
            return View(value);
        }
        public async Task<int> GetByUserID()
        {
            //var user = await _userService.FindByUserNameAsync(User.Identity.Name);
            //return user.Id;
            var username =  User.Identity.Name;
            var usermail =  u.User.TGetByFilter(x => x.UserName == username).Email;
            var writerid = u.Writer.TGetByFilter(x => x.WriterMail == usermail).WriterID;
            return writerid;
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Message2 message, string ReceiverMail)
        {
            if (ModelState.IsValid)
            {
                message.SenderID = await GetByUserID();
                //var receiver = await _userService.TGetByFilter(x=> x.Email == ReceiverMail);
                //if (receiver.Id != 0)
                //{
                //    message.ReceiverID = receiver.Id;
                //}
                //else
                //{
                //    return View();
                //}
                message.MessageStatus = true;
                message.MessageDate = DateTime.Now;
                _message2Service.TAdd(message);
                return RedirectToAction("Inbox");
            }
            return View();
        }
        public async Task<IActionResult> SendBox()
        {
            var values = _message2Service.GetSendBoxWithMessageByWriter(await GetByUserID());
            return View(values);
        }
    }
}
