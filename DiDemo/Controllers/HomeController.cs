using DiDemo.Models;
using DiDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DiDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVisiteursCompteur _vc ;

        public HomeController(ILogger<HomeController> logger, IVisiteursCompteur vc)
        {
            _logger = logger;
            _vc=vc;
        }

        public IActionResult Index()
        {
            ViewBag.vc = _vc.getCounter();
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.vc = _vc.getCounter();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
