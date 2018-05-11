using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationcore.Models;

namespace WebApplicationcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<SettingsOptions> options;
        public HomeController(IOptions<SettingsOptions> options)
        {
            this.options = options;
        }
        
        public IActionResult Index()
        {
            var value = options.Value;
            ViewBag.Index = value.PropA+"success";
            return View();
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
