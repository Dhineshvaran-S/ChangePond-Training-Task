using Firstapp.Models;
using Firstapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Firstapp.Controllers
{
    public class CalciController : Controller
    {

        public IActionResult Info()
        {
            Person person = new Person();
            person.name = "SENID";
            person.basicsalary = 10000;
            person.age = 21;
            return View(person);
        }
        public IActionResult Index()
        {
            ViewBag.Heading = "Hello Everyone";
            return View();
        }

        public IActionResult Greeting()
        {
            return View();
        }




    }
}