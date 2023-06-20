﻿using Microsoft.AspNetCore.Mvc;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.Content;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;
using System.Diagnostics;

namespace Project_StarWarsAPI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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