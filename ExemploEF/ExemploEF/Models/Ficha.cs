using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEF.Models
{
    public class Ficha
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Curso { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public string Instrutor { get; set; }

        [Display(Name ="Sala de Aula/Equipamento")]
        public int SalaEquipamentoNota { get; set; }

        [Display(Name = "Pontualidade")]
        public int PontualidadeNota { get; set; }

        [Display(Name = "Conteúdo Apresentado")]
        public int ConteudoNota { get; set; }

        [Display(Name = "Instrutor")]
        public int InstrutorNota { get; set; }

        public string Dificuldade { get; set; }

        [Display(Name = "Sugestão/Crítica")]
        public string Sugestao { get; set; }
    }
}
