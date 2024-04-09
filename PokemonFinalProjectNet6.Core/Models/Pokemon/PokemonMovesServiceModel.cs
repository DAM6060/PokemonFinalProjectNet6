using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Pokemon
{
    public class PokemonMovesServiceModel
    {
        public IEnumerable<int> MoveIds { get; set; } = new List<int>();
    }
}
