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
                // Console.WriteLine(NewUser);
                if(ImageFile != null)
                {
                    //Save image to wwwroot/image
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    Console.WriteLine(wwwRootPath);
                    Console.WriteLine(" ");
                    string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    Console.WriteLine(fileName);
                    Console.WriteLine(" ");
                    string extension = Path.GetExtension(ImageFile.FileName);
                    Console.WriteLine(extension);
                    Console.WriteLine(" ");
                    
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    Console.WriteLine(fileName);
                    Console.WriteLine(" ");
                    var filePath = Path.Combine(wwwRootPath + "/images/User", fileName);
                    Console.WriteLine(filePath);
                    Console.WriteLine(" ");
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
                .FirstOrDefault(u=>u.UserId == userid);

                List<Message> allmessages = _context.Messages
                .Include(m=>m.CommentsForMessage)
                .ThenInclude(c=>c.Creator)
                .Include(m=>m.Creator)
                .OrderByDescending(m=>m.UpdatedAt)
                .ToList();

                return View("Wall", _context);
            }else{
                return RedirectToAction("Index");
            }
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

