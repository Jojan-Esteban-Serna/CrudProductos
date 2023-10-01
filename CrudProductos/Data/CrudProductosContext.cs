using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudProductos.Models;

namespace CrudProductos.Data
{
    public class CrudProductosContext : DbContext
    {
        public CrudProductosContext (DbContextOptions<CrudProductosContext> options)
            : base(options)
        {
        }

        public DbSet<CrudProductos.Models.Producto> Producto { get; set; } = default!;
    }
}
