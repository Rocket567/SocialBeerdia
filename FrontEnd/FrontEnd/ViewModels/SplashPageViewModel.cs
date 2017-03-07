using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.ViewModels
{
    public class SplashPageViewModel
    {
        public List<Beer> TopFiveBeers { get; set; }
        public List<Pizza> TopFivePizzas { get; set; }
        public Pizza PizzaOfTheDay { get; set; }
        public Beer BeerOfTheDay { get; set; }
    }
}