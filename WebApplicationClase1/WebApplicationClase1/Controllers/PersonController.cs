using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationClase1.Models;

namespace WebApplicationClase1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var persons = new List<Person>();
            persons.Add(new Person { 
                Id = 1,
                Nombre = "Juan",
                Apellido = "Nizama"
            });
            return View(persons);
        }
    }
}
