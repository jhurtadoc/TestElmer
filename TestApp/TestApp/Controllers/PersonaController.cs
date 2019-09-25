using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class PersonaController: Controller
    {
        PersonaDbContext _db = new PersonaDbContext();
        public ActionResult Index()
        {
            var personas = _db.Persona.ToList();
            return View(personas);
        }
    }
}