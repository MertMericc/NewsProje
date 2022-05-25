using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsBlog.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new CommentRepository());
        public IActionResult AddComment()
        {
            return View();
        }

        public IActionResult AddComment(Comment p)
        {
            
            return View();
        }
    }
}
