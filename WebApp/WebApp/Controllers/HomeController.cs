using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Numbers()
        {
            return View();
        }
        public ActionResult FilesFromC()
        {
            var path = @"C:\";
            var files = Directory
              .GetDirectories(path)
              .ToList();
            files.AddRange(
              Directory.GetFiles(path));
            return View(files);
        }
        public ActionResult FilesFromWindows(
  string path = @"C:\")
        {
            var filesTwo = Directory
              .GetDirectories(path)
              .ToList();
            filesTwo.AddRange(Directory
             .GetFiles(path));
            ViewBag.Path = path;
            return View(filesTwo);
        }

    }
}