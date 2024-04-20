using System.ComponentModel.DataAnnotations;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;
namespace PokemonFinalProjectNet6.Core.Models.Player
{
    public class PlayerFormModel
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(PlayerMaxLength, MinimumLength =PlayerMinLength, ErrorMessage = LenghtMessage)]
        [Display(Name = "Player Name")]
        public string Name { get; set; } = null!;

        
    }
}
