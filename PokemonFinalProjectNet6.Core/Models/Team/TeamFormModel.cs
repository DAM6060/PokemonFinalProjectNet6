using PokemonFinalProjectNet6.Core.Models.Pokemon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<PokemonFormModel> Pokemon { get; set; } = new List<PokemonFormModel>();
    }
}
