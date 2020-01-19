using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLibreria.Entities
{
    public class Factura
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public Sede Sede { get; set; }
        public List<Libro> libros { get; set; }
    }
}
