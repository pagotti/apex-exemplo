using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBack.Models
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Postagem> Postagems { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            :base(options) { }
    }
}
