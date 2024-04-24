using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class Move 
	{
		[Key]
		[Comment("Identifier of a move")]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("Attack power of a move")]
		public int Power { get; set; }

		[Required]
		[Comment("Accuracy of a move")]
		public int Accuracy { get; set; }

		[Required]
		[Comment("How many times a use can be used in battle")]
		public int PowerPoints { get; set; }

		[Required]
		[Comment("Type of a move")]
		public string Type { get; set; } = string.Empty;
		
		[Comment("Chance of additional effect")]
		public int EffectChance { get; set; }
		
		[Comment("Name of additional effect")]
		public string Effect { get; set; } = string.Empty;

		public int EffectDuration { get; set; }
		
		[Comment("Ailment that attack may induce")]
		public string Ailment { get; set; } = string.Empty;

		[Comment("Chance of ailment being induced")]
		public int AilmentChance { get; set; }

		[Required]
		[Comment("Physical Special or Status")]
		public DamageClass DamageClass { get; set; }

		public bool? IsEffectUser { get; set; }

		[Comment("The percent of heath Restored Based on damage or userHealt")]
		public int HealAmount { get; set; }

		[Comment("If the heal is based on own Hp or DamageDelt")]
		public HealType HealType { get; set; } 

		public int Priority { get; set; }

		public List<PokemonMove> PokemonMoves { get; set; } = new List<PokemonMove>();

    }
}
