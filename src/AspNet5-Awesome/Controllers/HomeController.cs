using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.AspNet.Mvc;

namespace AspNet5_Awesome.Controllers
{
    public class HomeController : Controller
    {
        private readonly TelemetryClient _telemetry;

        public HomeController(TelemetryClient telemetry)
        {
            _telemetry = telemetry;
        }

        public IActionResult Index()
        {
            ViewData["Hello"] = "Hello";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"Your application description page. {DateTime.Now}";

            _telemetry.TrackEvent("About Loaded");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            _telemetry.TrackEvent("Contact Loaded");
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
