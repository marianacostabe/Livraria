using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Data
{
    public class Livros
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Código")]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        [Display(Name = "Ano Lançamento")]
        public DateTime AnoLancamento { get; set; }
    }
}
