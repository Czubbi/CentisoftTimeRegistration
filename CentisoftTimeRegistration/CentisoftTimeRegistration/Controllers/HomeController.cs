using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CentisoftTimeRegistration.Models;
using CentisoftAPI.Controllers;
using System.Net.Http;

namespace CentisoftTimeRegistration.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        ValuesController api= new ValuesController();
        public async Task<IActionResult> Index()
        {
            var stringTask = await client.GetStringAsync("https://localhost:5301/api/values");
            Console.WriteLine(stringTask);
            var a = api.Get();
            return View(a);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}