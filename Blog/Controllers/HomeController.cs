using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new BlogDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }
    }
}