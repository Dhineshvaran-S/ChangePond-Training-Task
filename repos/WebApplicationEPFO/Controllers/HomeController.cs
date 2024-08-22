using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationEPFO.Models;

namespace WebApplicationEPFO.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext CompanyContext;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CompanyContext cc)
        {
            _logger = logger;
            CompanyContext = cc;
        }

        public IActionResult Index()
        {
            var dept = new Department()
            {
                Name = "Information Technology"
            };
            CompanyContext.Entry(dept).State = EntityState.Added;
            CompanyContext.SaveChanges();
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
