using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using FsnApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FsnApp.Controllers
{
    public class HomeController : Controller
    {
        public IComponentService _componentService;

        public HomeController(IComponentService componentService)
        {
            _componentService = componentService;
        }

        public IActionResult Index()
        {
            Component com = new Component();
            com.ComponentId = Guid.NewGuid();
            com.Code = "F-EN-E23";
            com.Description = "ilk deneme";
            com.IsDeleted= false;

            _componentService.Add(com);

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
