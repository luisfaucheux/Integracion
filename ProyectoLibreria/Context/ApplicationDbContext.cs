using Microsoft.EntityFrameworkCore;
using ProyectoLibreria.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoLibreria.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Libro> libro { get; set; }
        public DbSet<Sede> sede { get; set; }

    }
}
