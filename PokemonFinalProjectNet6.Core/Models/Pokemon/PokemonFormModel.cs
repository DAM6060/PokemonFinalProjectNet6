using Microsoft.VisualBasic;
using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;

namespace PokemonFinalProjectNet6.Core.Models.Pokemon
{
    public class PokemonFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Level { get; set; } = PokemonLevel;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseHp { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvHp { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int HP => (int)((((double)2 * (double)BaseHp + ((double)EvHp / (double)4)) * (double)Level / (double)100) + (double)Level + (double)10);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Attack => (int)((((double)2 * (double)BaseAttack + ((double)EvAttack / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Defense => (int)((((double)2 * (double)BaseDefense + ((double)EvDefense / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpecialAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvSpecialAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int SpecialAttack => (int)((((double)2 * (double)BaseSpecialAttack + ((double)EvSpecialAttack / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpecialDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvSpecialDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int SpecialDefense => (int)((((double)2 * (double)BaseSpecialDefense + ((double)EvSpecialDefense / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpeed { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxEvPerStat, ErrorMessage = MaxEvStatErrorMessage)]
        public int EvSpeed { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Speed => (int)((((double)2 * (double)BaseSpeed + ((double)EvSpeed / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, MaxTotalEvPoints, ErrorMessage = MaxEvStatErrorMessage)]
        public int TotalEvPoints => EvHp + EvAttack + EvDefense + EvSpecialAttack + EvSpecialDefense + EvSpeed;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public PokemonTypeCustom Type1 { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public PokemonTypeCustom Type2 { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int AbilityId { get; set; }

        public IEnumerable<PokemonAbilityServiceModel> Abilities { get; set; } =
            new List<PokemonAbilityServiceModel>();

        public IEnumerable<PokemonMovesServiceModel> MovesDb { get; set; } =
       new List<PokemonMovesServiceModel>();

        public IEnumerable<MoveServiceModel> MovesForDropDown { get; set; } =
            new List<MoveServiceModel>();

        public int TeamId { get; set; }

        public int PlayerId { get; set; }



    }
}
