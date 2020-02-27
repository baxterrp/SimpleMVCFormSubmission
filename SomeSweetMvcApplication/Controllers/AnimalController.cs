using Microsoft.AspNetCore.Mvc;
using SomeSweetMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeSweetMvcApplication.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddAnimal(Animal animal) 
        {
            return View("NewAnimal", animal);
        }
    }
}
