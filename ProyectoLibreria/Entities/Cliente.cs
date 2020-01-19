using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLibreria.Entities
{
    public class Cliente
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }
        public List<Factura> Facturas { get; set; }

        public int RUC { get; set; }
    }
}
