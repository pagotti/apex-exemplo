using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogBack.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [JsonIgnore]
        public ICollection<CategoriaPostagem> Postagens { get; set; }
    }
}
