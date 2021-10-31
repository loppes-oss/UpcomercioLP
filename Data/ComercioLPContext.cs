using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComercioLP.Models;

namespace ComercioLP.Data
{
    public class ComercioLPContext : DbContext
    {
        public ComercioLPContext (DbContextOptions<ComercioLPContext> options)
            : base(options)
        {
        }

        public DbSet<ComercioLP.Models.Departament> Departament { get; set; }
    }
}
