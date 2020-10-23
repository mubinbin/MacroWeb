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
    public class CommentController : Controller
    {
        private MyContext _context;
        public CommentController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("newcommentpartial/{MessageId}")]
        public PartialViewResult NewComment(int MessageId)
        {

            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);
            ViewBag.allusers = _context.Users.ToList();
            ViewBag.curmessage = _context.Messages
            .FirstOrDefault(m=>m.MessageId==MessageId);

            return PartialView("_PostComment");
        }

        [ValidateAntiForgeryToken]
        [HttpPost("processnewcomment")]
        public IActionResult ProcessNewComment(Comment NewComment)
        {
            
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);
            ViewBag.curmessage = _context.Messages
            .FirstOrDefault(m=>m.MessageId==NewComment.MessageId);

            if(ModelState.IsValid)
            {
                _context.Comments.Add(NewComment);
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
                
                .Include(m=>m.Spirals)
                .Include(m=>m.Center)
                
                .OrderByDescending(m=>m.UpdatedAt)
                .ToList());
                
                var returnedJson = new
                {
                    successful = true,
                    renderPage = html
                };

                return Json(returnedJson);

            }else{

                var html = Helper.RenderRazorViewToString(this, "_PostComment", NewComment);

                var returnedJson = new 
                {
                    successful = false,
                    renderPage = html
                };
                return Json(returnedJson);
            }
        }

        // like comment
        [HttpGet("likecomment/{id}")]
        public JsonResult LikeComment(int id)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            LikedComment NewLike = new LikedComment();
            NewLike.UserId = userid;
            NewLike.CommentId = id;

            _context.LikedComments.Add(NewLike);
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
            
            .Include(m=>m.Spirals)
            .Include(m=>m.Center)
            
            .OrderByDescending(m=>m.UpdatedAt)
            .ToList());

            return Json(new{renderPage = html});
        }

        // unlike
        [HttpGet("unlikecomment/{id}")]
        public JsonResult UnLikeComment(int id)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            LikedComment ToDelete = _context.LikedComments
            .FirstOrDefault(l=>l.UserId==userid && l.CommentId==id);

            _context.LikedComments.Remove(ToDelete);
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
            
            .Include(m=>m.Spirals)
            .Include(m=>m.Center)
            
            .OrderByDescending(m=>m.UpdatedAt)
            .ToList());

            return Json(new{renderPage = html});
        }

        [HttpGet("userslikedcomment/{id}")]
        public PartialViewResult UsersLikedComment(int id)
        {   
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser =  _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            ViewBag.ThisComment = _context.Comments
            .Include(c=>c.UserLikedThisComment)
            .ThenInclude(lc=>lc.UserWhoLiked)
            .FirstOrDefault(c=>c.CommentId==id);
            
            return PartialView("_LikedCommentUsers");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}