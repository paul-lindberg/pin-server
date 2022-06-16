using Microsoft.AspNetCore.Mvc;
using PinServer.Models;
using System.Diagnostics;

namespace PinServer.Controllers
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
            List<RaspberryPi> res = Globals.SeedData;

            TcpTimeServer.Init(null);
            return View(res);
        }

        public IActionResult ProjectGoals()
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