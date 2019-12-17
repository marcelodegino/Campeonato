using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Campeonato.Models
{
    public class Jogador
    {
        [Display(Name = "código")]
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "Informe o seu nome", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe a sua idade", AllowEmptyStrings = false)]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe a sua nacionalidade", AllowEmptyStrings = false)]
        [Display(Name = "Nacionalidade")]
        public String Nacionalidade { get; set; }

        public ICollection<Placar> Placares { get; set; }
    }
}
