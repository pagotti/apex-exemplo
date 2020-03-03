using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppApex.Models
{
    public class AppApexDbContext : DbContext
    {

        public DbSet<Ficha> Fichas { get; set; }

        public AppApexDbContext(DbContextOptions<AppApexDbContext> options)
            : base(options)
        {
        }

    }
}
