using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLibreria.Entities
{
    public class Sede
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public List<Factura> Facturas { get; set; }
    }
}
