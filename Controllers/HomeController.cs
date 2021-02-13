using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MacroWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace MacroWeb.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment _hostEnvironment;
        private MyContext _context;
        public HomeController(MyContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        // Process Register
        [HttpPost("processregister")]
        public IActionResult ProcessReg(User NewUser, IFormFile ImageFile)
        {
            if(ModelState.IsValid)
            {
                // check email's uniqueness 
                if(_context.Users.Any(u=>u.Email==NewUser.Email))
                {
                    ModelState.AddModelError("Email", "This email has already been registered!");
                    return View("Index");
                }
                if(ImageFile != null)
                {
                    //Save image to wwwroot/image
                    // string wwwRootPath = _hostEnvironment.WebRootPath;
                    string wwwRootPath = "./wwwroot";
                    string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    string extension = Path.GetExtension(ImageFile.FileName);
                    
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    var filePath = Path.Combine(wwwRootPath + "/images/User", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        ImageFile.CopyTo(fileStream);
                    }

                    NewUser.ImagePath = "/images/User/" + fileName;
                }
                
                // hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);

                _context.Users.Add(NewUser);
                _context.SaveChanges();

                // auto log in after register
                HttpContext.Session.SetInt32("UserId", NewUser.UserId);

                return RedirectToAction("Wall");
            }else{
                return View("Index");
            }
        }


        // Process Login
        [HttpPost("processlogin")]
        public IActionResult ProcessLogin (Login CurUser)
        {
            if(ModelState.IsValid)
            {
                User UserInDb = _context.Users.FirstOrDefault(u=>u.Email == CurUser.LEmail);
                

                // check if the email exsit in DB
                if(UserInDb == null)
                {
                    ModelState.AddModelError("LPassword", "Invalid Email/Password");
                    return View("Index");
                }

                // varify password
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(CurUser, UserInDb.Password, CurUser.LPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LPassword", "Invalid Email/Password");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("UserId", UserInDb.UserId);
                return RedirectToAction("Wall");
            }
            return View("Index");
        }

        // Log out
        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpGet("wall")]
        public IActionResult Wall()
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");
                ViewBag.curuser = _context.Users
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .FirstOrDefault(u=>u.UserId == userid);

                ViewBag.allusers = _context.Users.ToList();

                return View("Wall", _context);
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpGet("userdetail/{id}")]
        public IActionResult UserDetail(int id)
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");
                ViewBag.curuser = _context.Users
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .FirstOrDefault(u=>u.UserId == userid);

                ViewBag.UserToView = _context.Users
                .Include(u=>u.Followers)
                .ThenInclude(c=>c.Follower)
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .Include(u=>u.PostMessages)
                .Include(u=>u.LikedMessages)
                .ThenInclude(l=>l.ThisLikedMessage)
                .FirstOrDefault(u=>u.UserId==id);

                return View("UserDetail");
            }else{
                return RedirectToAction("Index");
            }
        }

        // follow
        [ValidateAntiForgeryToken]
        [HttpPost("follow")]
        public RedirectToActionResult Follow(Connection NewConnection)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            ViewBag.UserToView = _context.Users
            .Include(u=>u.Followers)
            .ThenInclude(c=>c.Follower)
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .Include(u=>u.PostMessages)
            .Include(u=>u.LikedMessages)
            .ThenInclude(l=>l.ThisLikedMessage)
            .FirstOrDefault(u=>u.UserId==NewConnection.UserFollowedId);

            _context.Connections.Add(NewConnection);
            _context.SaveChanges();

            return RedirectToAction("UserDetail", new{id=NewConnection.UserFollowedId});
        }

        // unfollow
        [ValidateAntiForgeryToken]
        [HttpPost("unfollow")]
        public RedirectToActionResult Unfollow(int UserFollowedId, int FollowerId)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .FirstOrDefault(u=>u.UserId == userid);

            ViewBag.UserToView = _context.Users
            .Include(u=>u.Followers)
            .ThenInclude(c=>c.Follower)
            .Include(u=>u.UsersFollowed)
            .ThenInclude(c=>c.UserFollowed)
            .Include(u=>u.PostMessages)
            .Include(u=>u.LikedMessages)
            .ThenInclude(l=>l.ThisLikedMessage)
            .FirstOrDefault(u=>u.UserId==UserFollowedId);

            Connection ToDelete = _context.Connections
            .FirstOrDefault(c=>c.UserFollowedId==UserFollowedId && c.FollowerId==FollowerId);

            _context.Connections.Remove(ToDelete);
            _context.SaveChanges();

            return RedirectToAction("UserDetail", new{id=UserFollowedId});
        }

        [HttpGet("editprofile")]
        public IActionResult EditProfile(int id)
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");
                ViewBag.curuser = _context.Users
                .FirstOrDefault(u=>u.UserId == userid);

                return PartialView("_EditProfile");
            }else{
                return RedirectToAction("Index");
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost("processeditprofile")]
        public IActionResult ProcssEdit(string Name, IFormFile ImageFile)
        {
            if(ModelState.IsValid)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");
                User curuser = _context.Users
                .FirstOrDefault(u=>u.UserId == userid);

                curuser.Name = Name;

                if(ImageFile != null)
                {
                    //Save image to wwwroot/image
                    // string wwwRootPath = _hostEnvironment.WebRootPath;
                    string wwwRootPath = "./wwwroot";

                    string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    string extension = Path.GetExtension(ImageFile.FileName);
                    
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    var filePath = Path.Combine(wwwRootPath + "/images/User", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        ImageFile.CopyTo(fileStream);
                    }

                    curuser.ImagePath = "/images/User/" + fileName;
                }
                _context.SaveChanges();
                return RedirectToAction("UserDetail", new{id=userid});
            }else
            {
                return View("_EditProfile");
            }
            
        }

        [HttpGet("allusers")]
        public IActionResult AllUsers()
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");

                ViewBag.curuser = _context.Users
                .Include(u=>u.UsersFollowed)
                .ThenInclude(c=>c.UserFollowed)
                .FirstOrDefault(u=>u.UserId == userid);

                ViewBag.allusers = _context.Users
                .Include(u=>u.Followers)
                .ThenInclude(c=>c.Follower)
                .Where(u=> u.UserId!=userid && !u.Followers.Any(c=>c.Follower.UserId == userid  ))
                .ToList();

                return PartialView("_AllUsers");
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpPost("followmultiple")]
        public RedirectToActionResult FollowMultiple(List<int> UsersAreChecked)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            foreach(int id in UsersAreChecked)
            {
                Connection NewConnection = new Connection()
                {
                    UserFollowedId = id,
                    FollowerId = userid
                };
                _context.Connections.Add(NewConnection);
                _context.SaveChanges();
            }
            return RedirectToAction("Wall");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

