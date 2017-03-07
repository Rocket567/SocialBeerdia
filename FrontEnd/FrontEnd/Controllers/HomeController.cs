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
            model.TopFiveBeers.Add(new Beer { Name = "Ale" });
            model.TopFiveBeers.Add(new Beer { Name = "Lager" });
            model.TopFiveBeers.Add(new Beer { Name = "Stout" });
            model.TopFiveBeers.Add(new Beer { Name = "Pale Ale" });
            model.TopFiveBeers.Add(new Beer { Name = "Pilsner" });

            model.TopFivePizzas.Add(new Pizza { Name = "Cheese" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pepperoni" });
            model.TopFivePizzas.Add(new Pizza { Name = "Hawaiian" });
            model.TopFivePizzas.Add(new Pizza { Name = "Combination" });
            model.TopFivePizzas.Add(new Pizza { Name = "Sausage" });
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