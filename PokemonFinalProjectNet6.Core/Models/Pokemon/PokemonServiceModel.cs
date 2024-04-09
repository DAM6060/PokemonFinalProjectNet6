using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Core.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Pokemon
{
    public class PokemonServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int PokeDexNumber { get; set; }

        public int BaseHp { get; set; }

        public int EvHp { get; set; }

        public int HP { get; set; }

        public int BaseAttack { get; set; }

        public int EvAttack { get; set;}

        public int Attack { get; set; }

        public int BaseSpecialAttack { get; set; }

        public int EvSpecialAttack { get; set; }

        public int SpecialAttack { get; set; }

        public int BaseDefense { get; set; }

        public int EvDefense { get; set; }

        public int Defense { get; set; }

        public int BaseSpecialDefense { get; set; }

        public int EvSpecialDefense { get; set; }

        public int SpecialDefense { get; set; }

        public int BaseSpeed { get; set; }

        public int EvSpeed { get; set; }

        public int Speed { get; set; }

        public string Type1 { get; set; } = string.Empty;

        public string Type2 { get; set; } = string.Empty;

        public AbilityServiceModel Ability { get; set; }

        //public PlayerServiceModel Player { get; set; }

        // List<MoveServiceModel> Moves { get; set; } = new List<MoveServiceModel>();

       
    }
}
