﻿using MVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCBlog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
              //Get: Posts
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(5);
            return View(posts.ToList());
        }
    }
}