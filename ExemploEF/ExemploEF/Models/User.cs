using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEF.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Data Nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}
