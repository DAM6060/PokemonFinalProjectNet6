using PokemonFinalProjectNet6.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Core.Models.Move
{
	public class MoveFormModel
	{
		static MoveFormModel()
		{
			Types = Enum.GetValues(typeof(PokemonTypeCustom))
				.Cast<PokemonTypeCustom>()
				.ToList();
			DamageClasses = Enum.GetValues(typeof(DamageClass))
				.Cast<DamageClass>()
				.ToList();
			HealTypes = Enum.GetValues(typeof(HealType))
				.Cast<HealType>()
				.ToList();
		}
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		public string Description { get; set; } = string.Empty;
		[Required]
		public PokemonTypeCustom Type { get; set; }
		[Required]
		public int Power { get; set; }
		[Required]
		public int PowerPoints { get; set; }
		[Required]
		public int Accuracy { get; set; }

		public int EffectChance { get; set; }

		public string Effect { get; set; } = string.Empty;

		public int EffectDuration { get; set; }

		public string Ailment { get; set; } = string.Empty;

		public int AilmentChance { get; set; }
		[Required]
		public DamageClass DamageClass { get; set; }

		public bool? IsEffectUser { get; set; }

		public string isEffectUserString { get; set; } = string.Empty;

		public int HealAmount { get; set; }

		public HealType HealType { get; set; }

		public int Priority { get; set; }

		public static List<PokemonTypeCustom> Types { get; set; } = new List<PokemonTypeCustom>();

		public static List<DamageClass> DamageClasses { get; set; } = new List<DamageClass>();

		public static List<HealType> HealTypes { get; set; } = new List<HealType>();
	}
}
