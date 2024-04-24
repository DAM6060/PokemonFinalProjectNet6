using PokemonFinalProjectNet6.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;

namespace PokemonFinalProjectNet6.Core.Models.Pokemon
{
	public class PokemonSpeciesFormModel
	{
		static PokemonSpeciesFormModel()
		{
			Types = Enum.GetValues(typeof(PokemonTypeCustom))
				.Cast<PokemonTypeCustom>()
				.ToList();
		}
		[Required]
		public string Name { get; set; } = string.Empty;
		public int Level { get; set; } = PokemonLevel;
		[Required]
		public int BaseHP { get; set; }
		[Required]
		public int BaseAttack { get; set; }
		[Required]
		public int BaseDefense { get; set; }
		[Required]
		public int BaseSpecialAttack { get; set; }
		[Required]
		public int BaseSpecialDefense { get; set; }
		[Required]
		public int BaseSpeed { get; set; }
		[Required]
		public PokemonTypeCustom Type1 { get; set; }
		[Required]
		public PokemonTypeCustom Type2 { get; set; }
		public int AbilityId { get; set; } = PokemonCreationAbilityId;
		public int TeamId { get; set; } = AdminUserTeamId;
		public int PlayerId { get; set; } = AdminPlayerUserId;
		public int HP { get; set; } = 0;
		public int Attack { get; set; } = 0;
		public int Defense { get; set; } = 0;
		public int SpecialAttack { get; set; } = 0;
		public int SpecialDefense { get; set; } = 0;
		public int Speed { get; set; } = 0;
		public int EvHP { get; set; } = 0;
		public int EvAttack { get; set; } = 0;
		public int EvDefense { get; set; } = 0;
		public int EvSpecialAttack { get; set; } = 0;
		public int EvSpecialDefense { get; set; } = 0;
		public int EvSpeed { get; set; } = 0;
		public static List<PokemonTypeCustom> Types { get; set; } = new List<PokemonTypeCustom>();



	}
}
