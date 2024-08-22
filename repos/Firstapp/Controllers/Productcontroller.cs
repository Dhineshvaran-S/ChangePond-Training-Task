using Firstapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Firstapp.Controllers
{
    public class Productcontroller : Controller
    {

        public IActionResult Product()
        {
            Product prod = new Product();
            prod.Name = "LINGA";
            prod.Price = 1000;
            prod.Description = "Model";
            return View(prod);



        }
    }

}