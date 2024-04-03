using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class PokemonMove
    {
        [Required]
        public int PokemonId { get; set; }
        [Required]
        public Pokemon Pokemon { get; set; } = null!;
        [Required]
        public int MoveId { get; set; }
        [Required]
        public Move Move { get; set; } = null!;
    }
}
