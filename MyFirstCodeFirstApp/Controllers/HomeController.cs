using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstCodeFirstApp.Models;
using System.Web.Mvc;

namespace MyFirstCodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyBlogDBEntities db = new MyBlogDBEntities();
            db.Categories.ToList();
            //db.Posts.ToList();

            return View();
        }
    }
}