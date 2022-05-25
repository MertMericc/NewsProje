using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsBlog.ViewComponents.Comment
{
    public class Comment:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new CommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.TGetList();
            return View(values);
        }
    }
}
