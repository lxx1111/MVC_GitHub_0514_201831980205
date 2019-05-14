using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GitHub_0514_201831980205.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyAction1()
        {
            ViewBag.Message = "这是我的第一个MyAction";
            ViewBag.Xingming = "卢晓霞";
            ViewBag.Xuehao = "201831980205";
            return View();
        }
        public ActionResult MyAction2()
        {
            ViewBag.Message = "这是我的第二个MyAction";
            ViewBag.Xingming = "卢晓霞";
            ViewBag.Xuehao = "201831980205";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}