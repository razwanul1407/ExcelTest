using ExcelTest.Data;
using ExcelTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExcelTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _db;

        public HomeController(ILogger<HomeController> logger , DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var profile = _db.Patients.Add(Patients entity)
            return View();
        }

/*        public IActionResult Privacy()
        {
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}