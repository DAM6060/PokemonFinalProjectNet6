using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class BattleTeamServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        public List<BattlePokemonServiceModel> Pokemons { get; set; } = new List<BattlePokemonServiceModel>();

        public int PlayerId { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
    }
}
