using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class Persona
    {
        [Key]        
        public int IdPersona { get; set; }        
        public string Nombre { get; set; }        
        public string Direccion { get; set; }
        public bool EsSoltero { get; set; }
    }
}