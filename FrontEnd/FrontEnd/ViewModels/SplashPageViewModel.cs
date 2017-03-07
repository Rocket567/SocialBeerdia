using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.ViewModels
{
    public class SplashPageViewModel
    {
        public SplashPageViewModel()
        {
            TopFiveBeers = new List<Beer>();
            TopFivePizzas = new List<Pizza>();
        }

        public List<Beer> TopFiveBeers { get; set; }
        public List<Pizza> TopFivePizzas { get; set; }
        public Pizza PizzaOfTheDay { get; set; }
        public Beer BeerOfTheDay { get; set; }
    }
}