using FrontEnd.Models;
using FrontEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SplashPageViewModel();
            model.TopFiveBeers.Add(new Beer { Name = "Beer 1" });
            model.TopFiveBeers.Add(new Beer { Name = "Beer 2" });
            model.TopFiveBeers.Add(new Beer { Name = "Beer 3" });
            model.TopFiveBeers.Add(new Beer { Name = "Beer 4" });
            model.TopFiveBeers.Add(new Beer { Name = "Beer 5" });

            model.TopFivePizzas.Add(new Pizza { Name = "Pizza 1" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pizza 2" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pizza 3" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pizza 4" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pizza 5" });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            ////test

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}