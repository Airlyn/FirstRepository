using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 小仙女5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Me()
        {
            ViewBag.Message = "Welcome to My World!";
            return View();
        }
        public ActionResult SUM()
        {
            ViewBag.Message = "Please Do Your Calculations!";
            return View("SUM");
        }
        public ActionResult F1(int a,int b)
        {
            int sum=a+b;
            ViewBag.a=sum;
            return View("SUM");
        }
    }
}