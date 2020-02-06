using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEF.Models
{
    public class UserDbContext : DbContext
    {
        public virtual DbSet<Usuario> Usuarios { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options)
            :base(options)
        { 
        }
    }
}
