using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBack.Models
{
    public class Postagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        [Required]
        public string Texto { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public string Foto { get; set; }

        [ForeignKey("Autor")]
        public int AutorId { get; set; }

        public Autor Autor { get; set; }

        public ICollection<CategoriaPostagem> Categorias { get; set; }

        public ICollection<Comentario> Comentarios { get; set; }
    }
}
