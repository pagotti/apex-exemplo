using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogBack.Models
{
    public class CategoriaPostagem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        [ForeignKey("Postagem")]
        public int PostagemId { get; set; }

        [JsonIgnore]
        public Postagem Postagem { get; set; }

    }
}
