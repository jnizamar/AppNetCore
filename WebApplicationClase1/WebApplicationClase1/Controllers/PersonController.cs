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
            var persons = new List<PersonViewModel>();
            persons.Add(new PersonViewModel { 
                Id = 1,
                Nombre = "Juan",
                Apellido = "Nizama"
            });
            return View(persons);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult CreatePerson(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Registrar", person);
            }   
        }
    }
}
