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
        
        public int EvHp { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int HP => (int)((((double)2 * (double)BaseHp + ((double)EvHp / (double)4)) * (double)Level / (double)100) + (double)Level + (double)10);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseAttack { get; set; }

		[Required(ErrorMessage = RequiredErrorMessage)]
		
		public int EvAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Attack => (int)((((double)2 * (double)BaseAttack + ((double)EvAttack / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseDefense { get; set; }
		[Required(ErrorMessage = RequiredErrorMessage)]
		
		public int EvDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Defense => (int)((((double)2 * (double)BaseDefense + ((double)EvDefense / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpecialAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        
        public int EvSpecialAttack { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int SpecialAttack => (int)((((double)2 * (double)BaseSpecialAttack + ((double)EvSpecialAttack / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpecialDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int EvSpecialDefense { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int SpecialDefense => (int)((((double)2 * (double)BaseSpecialDefense + ((double)EvSpecialDefense / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int BaseSpeed { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int EvSpeed { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int Speed => (int)((((double)2 * (double)BaseSpeed + ((double)EvSpeed / (double)4)) * (double)Level / (double)100) + (double)5);

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(typeof(int), MinEvPerStat, MaxTotalEvPoints, ErrorMessage = MaxEvStatErrorMessage)]
        public int TotalEvPoints => EvHp + EvAttack + EvDefense + EvSpecialAttack + EvSpecialDefense + EvSpeed;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public PokemonTypeCustom Type1 { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public PokemonTypeCustom Type2 { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int AbilityId { get; set; }

        public int Move1IdForDb { get; set; }      
        public int Move2IdForDb { get; set; }      
        public int Move3IdForDb { get; set; }      
        public int Move4IdForDb { get; set; }      
        public HashSet<int> MovesIdsForDb => new HashSet<int> { Move1IdForDb, Move2IdForDb, Move3IdForDb, Move4IdForDb };
		public int TeamId { get; set; }

        public int PlayerId { get; set; }

		public IEnumerable<MoveServiceModel> MovesForDropDown { get; set; } = new List<MoveServiceModel>();
		public IEnumerable<AbilityServiceModel> Abilities { get; set; } = new List<AbilityServiceModel>();


	}
}
