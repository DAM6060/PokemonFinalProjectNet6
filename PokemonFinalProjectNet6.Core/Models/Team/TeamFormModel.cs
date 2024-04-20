using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Models.Pokemon;
using System.ComponentModel.DataAnnotations;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;



namespace PokemonFinalProjectNet6.Core.Models.Team
{
	public class TeamFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(TeamNameMaxLength, 
            MinimumLength =TeamNameMinLength, 
            ErrorMessage =TeamNameMaxLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;        
        
        public PokemonFormModel? PokemonForDB1 { get; set; }
        public PokemonFormModel? PokemonForDB2 { get; set; }
        public PokemonFormModel? PokemonForDB3 { get; set; }
        
        public List<string> ChosenPokemons { get; set; } = new List<string>();

        public string ChosenPokemon1 { get; set; } = string.Empty;
        public string ChosenPokemon2 { get; set; } = string.Empty;
        public string ChosenPokemon3 { get; set; } = string.Empty;

        [Required]
        public int PlayerId { get; set; }

        public IEnumerable<string> PokemonSpecies { get; set; } = new List<string>();
		public IEnumerable<AbilityServiceModel> Abilities { get; set; } =
			new List<AbilityServiceModel>();
		public IEnumerable<MoveServiceModel> MovesForDropDown { get; set; } =
			new List<MoveServiceModel>();
	}
}
