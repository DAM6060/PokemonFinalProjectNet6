using PokemonFinalProjectNet6.Core.Models.Pokemon;
using System.ComponentModel.DataAnnotations;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;


namespace PokemonFinalProjectNet6.Core.Models.Team
{
    public class Team3v3FormModel
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(TeamNameMaxLength,ErrorMessage =TeamNameMaxLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(TeamMaxPokemonCount3v3 , ErrorMessage = TeamMaxPokemonCountErrorMessage)]
        public List<PokemonFormModel> Pokemons { get; set; } = new List<PokemonFormModel>();
    }
}
