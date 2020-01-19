using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoLibreria.Context;
using ProyectoLibreria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLibreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public FacturaController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Factura>> Get()
        {
            var factura = context.facturas.Include(x=>x.libros).Include(x=>x.Cliente).Include(x=>x.Sede).ToList();
            return factura;
        }

        [HttpGet("{id}", Name = "ObtenerFactura")]
        public async Task<ActionResult<Factura>> Get(int id)
        {
            var factura = await context.facturas.FirstOrDefaultAsync(x => x.ID == id);

            if (factura == null)
            {
                return NotFound();
            }
            return factura;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Factura factura)
        {
            context.Add(factura);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("ObtenerFactura", new { id = factura.ID }, factura);
        }
    }
}
