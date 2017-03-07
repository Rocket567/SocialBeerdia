﻿using FrontEnd.Models;
using FrontEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {

       

    
    public async Task<ActionResult> Index()
        {

             //  Get("sss");

       //     MakeRequest();
        var blah = await GetBeerAsync("beer/beer/");

       


            var model = new SplashPageViewModel();
        model.TopFiveBeers = blah.Take(5).ToList();
            //model.TopFiveBeers.Add(new Beer { Name = "Beer 1" });
            //model.TopFiveBeers.Add(new Beer { Name = "Beer 2" });
            //model.TopFiveBeers.Add(new Beer { Name = "Beer 3" });
            //model.TopFiveBeers.Add(new Beer { Name = "Beer 4" });
            //model.TopFiveBeers.Add(new Beer { Name = "Beer 5" });

            model.TopFivePizzas.Add(new Pizza { Name = "Cheese" });
            model.TopFivePizzas.Add(new Pizza { Name = "Pepperoni" });
            model.TopFivePizzas.Add(new Pizza { Name = "Hawaiian" });
            model.TopFivePizzas.Add(new Pizza { Name = "Combination" });
            model.TopFivePizzas.Add(new Pizza { Name = "Sausage" });
            return View(model);
        }

        static async Task<List<Beer>> GetBeerAsync(string path)
        {
             HttpClient client = new HttpClient();
            //  client.BaseAddress = new Uri("http://socialbeerdiawebapi.azurewebsites.net/");
            client.BaseAddress = new Uri("http://beerdia.azure-api.net");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "7f741adb79164a79a91d66cc54aa1080");

            List<Beer> beers = new List<Beer>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                beers = await response.Content.ReadAsAsync<List<Beer>>();
            }
            client.Dispose();

            if (beers.Count == 0)
            {
                beers.Add(new Beer { Name = "You're too drunk" });
            }

            return beers;
        }
        //static async void MakeRequest()
        //{
        //    var client = new HttpClient();
        //    var queryString = HttpUtility.ParseQueryString(string.Empty);

        //    // Request headers
        //    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "dd5c6e92a043401a9c5a26c4e60938d0");
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    var uri = "http://beerdia.azure-api.net/beer/beer/?" + queryString;

        //    var response = await client.GetAsync(uri);
        //}



        //public Beer Get(string id)
        //{
        //    var rtn = default(Beer);

        //    var task = Task.Run(() => GetBeerAsync("api/beer"));
        //    var result = task.Result;
        //    //var status = result?.Status;
        //    //if (!string.IsNullOrEmpty(status) && status == "success")
        //    //{
        //    //    rtn = result.Data;
        //    //}

        //    return rtn;
        //}

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