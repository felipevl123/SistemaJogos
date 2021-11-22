using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogos.Controllers
{
    public class Jogos
    {

        // Propriedades da classe modelo Jogos

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Estudio { get; set; }
        [Required]
        public string Genero { get; set; }


    }
}
