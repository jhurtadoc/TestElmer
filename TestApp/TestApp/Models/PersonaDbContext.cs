using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class PersonaDbContext: DbContext
    {
        public PersonaDbContext(): base("name=VictoriaBD")
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}