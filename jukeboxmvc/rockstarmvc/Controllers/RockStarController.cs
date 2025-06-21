using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rockstarmvc.Models;

//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
using System.Net;
using System.IO;
using System.Text;

namespace rockstarmvc.Controllers
{
    public class RockStarController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public RockStarController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Faith()
        {
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
