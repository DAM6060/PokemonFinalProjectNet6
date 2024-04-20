using PokemonFinalProjectNet6.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class BattlePokemonServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public PokemonTypeCustom Type1 { get; set; }
        public PokemonTypeCustom Type2 { get; set; }
        public BattleAbilityServiceModel Ability { get; set; }
        public List<BattleMoveServiceModel> Moves { get; set; } = new List<BattleMoveServiceModel>();
        public bool IsFainted { get; set; }
        
    }
}
