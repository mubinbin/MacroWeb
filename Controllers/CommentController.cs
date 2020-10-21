using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MacroWeb.Models;
using Microsoft.AspNetCore.Http;

namespace MacroWeb.Controllers
{
    public class CommentController : Controller
    {
        private MyContext _context;
        public CommentController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}