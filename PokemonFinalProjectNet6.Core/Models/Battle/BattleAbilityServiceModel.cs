using PokemonFinalProjectNet6.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class BattleAbilityServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PhaseOfCombatAbility PhaseOfCombatAbilityActivation { get; set; }
    }
}
