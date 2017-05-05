using Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var model = new List<MyClass>();
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {

                model.Add(
                    new MyClass
                    {
                        category = "收入",
                        date = DateTime.Now,
                        money = random.Next()/1000
                    });
                model.Add(
                    new MyClass
                    {
                        category = "支出",
                        date = DateTime.Now,
                        money = random.Next()/1000
                    });
            }



            return View(model);
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