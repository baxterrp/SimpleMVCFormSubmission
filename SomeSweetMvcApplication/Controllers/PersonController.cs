using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomeSweetMvcApplication.Models;

namespace SomeSweetMvcApplication.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPerson(Person person)
        {
            ViewBag.Name = person.Name;

            if(person.Name == "Robert")
            {
                return View("RobertsPage");
            }

            if(person.Age >= 21)
            {
                return View("NewPerson", person);
            }

            return View("NotTwentyOne");
        }
    }
}