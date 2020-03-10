using System.ComponentModel.DataAnnotations;

namespace BlogBack.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

    }
}