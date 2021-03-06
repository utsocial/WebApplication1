﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ICountriesRepository CountriesRepositoryInMemory { get; }

        public HomeController(ICountriesRepository countriesRepositoryInMemory)
        {
            CountriesRepositoryInMemory = countriesRepositoryInMemory;
        }

        public IActionResult Index()
        {
            // throw new ApplicationException("Somting bad happen!!! ");
            var hardCodedContries = CountriesRepositoryInMemory.getCountries();
            return View(hardCodedContries);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
