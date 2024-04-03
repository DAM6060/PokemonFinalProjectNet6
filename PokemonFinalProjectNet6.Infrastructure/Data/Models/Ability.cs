using PokemonFinalProjectNet6.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models
{
    public class Ability
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public string Description { get; set; } = string.Empty;

		[Required]
		public PhaseOfCombatAbility PhaseOfCombatActivaton { get; set; }		
	}
}
