using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloController : Controller
    {
        // GET:/ Hello/
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult Welcomr(string name, int times = 1)
        {
            ViewBag.msg = "你好" + name + "!";
            ViewBag.times = times;
            return View();
        }
    }
}