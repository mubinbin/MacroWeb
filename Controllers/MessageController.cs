using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MacroWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace MacroWeb.Controllers
{
    public class MessageController : Controller
    {
        private MyContext _context;
        public MessageController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("newmessagepartial")]
        public PartialViewResult NewMessage()
        {

            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            return PartialView("_PostMessage");
        }

        [ValidateAntiForgeryToken]
        [HttpPost("processnewmessage")]
        public IActionResult ProcessNewMessage(Message NewMessage)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            if(ModelState.IsValid)
            {
                _context.Messages.Add(NewMessage);
                _context.SaveChanges();


                var html = Helper.RenderRazorViewToString(this, "_ShowMessage", _context.Messages
                .Include(m=>m.CommentsForMessage)
                .ThenInclude(c=>c.Creator)

                .Include(m=>m.CommentsForMessage)
                .ThenInclude(c=>c.UserLikedThisComment)
                .ThenInclude(lc=>lc.UserWhoLiked)

                .Include(m=>m.Creator)
                .Include(m=>m.UsersLikedThisMessage)
                .ThenInclude(lm=>lm.UserWhoLiked)

                .OrderByDescending(m=>m.UpdatedAt)
                .ToList());
                
                var returnedJson = new
                {
                    successful = true,
                    renderPage = html
                };

                return Json(returnedJson);

            }else{

                var html = Helper.RenderRazorViewToString(this, "_PostMessage", NewMessage);

                var returnedJson = new 
                {
                    successful = false,
                    renderPage = html
                };
                return Json(returnedJson);
            }
        }

        [HttpGet("editmessagepartial/{MessageId}")]
        public IActionResult EditMessage(int MessageId)
        {   
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");

                ViewBag.curuser = _context.Users
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .FirstOrDefault(u=>u.UserId == userid);
                ViewBag.curMessage = _context.Messages
                .FirstOrDefault(m=>m.MessageId==MessageId);

                return PartialView("_EditMessage");
            }else{
                return RedirectToAction("Index","Home");
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost("processeditmessage")]
        public IActionResult ProcessEditMessage(Message EditMessage)
        {
            
                int userid = (int)HttpContext.Session.GetInt32("UserId");

                ViewBag.curuser = _context.Users
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .FirstOrDefault(u=>u.UserId == userid);
                ViewBag.curMessage = _context.Messages
                .FirstOrDefault(m=>m.MessageId==EditMessage.MessageId);

                if(ModelState.IsValid)
                {
                    Message CurMessage = _context.Messages
                    .FirstOrDefault(m=>m.MessageId==EditMessage.MessageId);
                    CurMessage.MessageContent = EditMessage.MessageContent;
                    CurMessage.UpdatedAt = DateTime.Now;
                    _context.SaveChanges();

                    var html = Helper.RenderRazorViewToString(this, "_ShowMessage", _context.Messages
                    .Include(m=>m.CommentsForMessage)
                    .ThenInclude(c=>c.Creator)

                    .Include(m=>m.CommentsForMessage)
                    .ThenInclude(c=>c.UserLikedThisComment)
                    .ThenInclude(lc=>lc.UserWhoLiked)

                    .Include(m=>m.Creator)
                    .Include(m=>m.UsersLikedThisMessage)
                    .ThenInclude(lm=>lm.UserWhoLiked)
                    
                    .OrderByDescending(m=>m.UpdatedAt)
                    .ToList());
                    
                    var returnedJson = new
                    {
                        successful = true,
                        renderPage = html
                    };

                    return Json(returnedJson);

                }else{

                    var html = Helper.RenderRazorViewToString(this, "_EditMessage", EditMessage);

                    var returnedJson = new 
                    {
                        successful = false,
                        renderPage = html
                    };
                    return Json(returnedJson);
                }
            
        }

        // delete message or comment
        [ValidateAntiForgeryToken]
        [HttpPost("deletemessage")]
        public JsonResult DelMes(int MessageId, int CommentId)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);
            
            if(MessageId != 0)
            {
                Message MessageToDelete = _context.Messages
                .FirstOrDefault(m=>m.MessageId==MessageId);
                _context.Messages.Remove(MessageToDelete);
                _context.SaveChanges();

            }else{
                Comment CommentToDelete = _context.Comments
                .FirstOrDefault(c=>c.CommentId==CommentId);
                _context.Comments.Remove(CommentToDelete);
                _context.SaveChanges();
            }

            var html = Helper.RenderRazorViewToString(this,"_ShowMessage", _context.Messages
            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.Creator)

            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.UserLikedThisComment)
            .ThenInclude(lc=>lc.UserWhoLiked)

            .Include(m=>m.Creator)
            .Include(m=>m.UsersLikedThisMessage)
            .ThenInclude(lm=>lm.UserWhoLiked)
            
            .OrderByDescending(m=>m.UpdatedAt)
            .ToList());

            var returnedJson = new
            {
                renderPage = html
            };

            return Json(returnedJson);
        }


        // like message
        [HttpGet("likemessage/{id}")]
        public JsonResult LikeMessage(int id)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            LikedMessage NewLike = new LikedMessage();
            NewLike.UserId = userid;
            NewLike.MessageId = id;

            _context.LikedMessages.Add(NewLike);
            _context.SaveChanges();

            var html = Helper.RenderRazorViewToString(this,"_ShowMessage", _context.Messages
            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.Creator)

            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.UserLikedThisComment)
            .ThenInclude(lc=>lc.UserWhoLiked)

            .Include(m=>m.Creator)
            .Include(m=>m.UsersLikedThisMessage)
            .ThenInclude(lm=>lm.UserWhoLiked)
            
            .OrderByDescending(m=>m.UpdatedAt)
            .ToList());

            return Json(new{renderPage = html});
        }

        // unlike
        [HttpGet("unlikemessage/{id}")]
        public JsonResult UnLikeMessage(int id)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            LikedMessage ToDelete = _context.LikedMessages
            .FirstOrDefault(l=>l.UserId==userid && l.MessageId==id);

            _context.LikedMessages.Remove(ToDelete);
            _context.SaveChanges();

            var html = Helper.RenderRazorViewToString(this,"_ShowMessage", _context.Messages
            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.Creator)

            .Include(m=>m.CommentsForMessage)
            .ThenInclude(c=>c.UserLikedThisComment)
            .ThenInclude(lc=>lc.UserWhoLiked)

            .Include(m=>m.Creator)
            .Include(m=>m.UsersLikedThisMessage)
            .ThenInclude(lm=>lm.UserWhoLiked)
            
            .OrderByDescending(m=>m.UpdatedAt)
            .ToList());

            return Json(new{renderPage = html});
        }

        // userslikedmessage/MessageId
        [HttpGet("userslikedmessage/{id}")]
        public PartialViewResult UsersLikedMessage(int id)
        {   
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser =  _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            ViewBag.ThisMessage = _context.Messages
            .Include(m=>m.UsersLikedThisMessage)
            .ThenInclude(lm=>lm.UserWhoLiked)
            .FirstOrDefault(m=>m.MessageId==id);
            
            return PartialView("_LikedMessageUsers");
        }




















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}