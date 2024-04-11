using PokemonFinalProjectNet6.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class BattleMoveServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public int PP { get; set; }
        public PokemonTypeCustom Type { get; set; }
        public int EffectChance { get; set; }
        public string Effect { get; set; } = string.Empty;
        public int EffectDuration { get; set; }
        public string Ailment { get; set; } = string.Empty;
        public int AilmentChance { get; set; }
        public DamageClass DamageClass { get; set; }
        public bool? IsEffectUser { get; set; }
        public int HealAmount { get; set; }
        public HealType HealType { get; set; }
        public int Priority { get; set; }



        
    }
}
