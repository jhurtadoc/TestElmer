namespace TestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        [StringLength(128)]
        public string Nombre { get; set; }

        [StringLength(128)]
        public string Direccion { get; set; }

        public bool EsSoltero { get; set; }
    }
}
