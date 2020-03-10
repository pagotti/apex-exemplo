using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogBack.Models
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Texto { get; set; }

        public DateTime Data { get; set; }

        [Required]
        public string Comentarista { get; set; }

        [ForeignKey("Postagem")]
        public int PostagemId { get; set; }

        [JsonIgnore]
        public Postagem Postagem { get; set; }

    }
}
