using PokemonFinalProjectNet6.Core.Models.Ability;
using PokemonFinalProjectNet6.Core.Models.Move;
using System.ComponentModel.DataAnnotations;
using static PokemonFinalProjectNet6.Infrastructure.Constants.Constant;


namespace PokemonFinalProjectNet6.Core.Models.Pokemon
{
    public class PokemonFormModel
    {
        public int Id { get; set; }

        public int PokeDexNumber { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; } = PokemonLevel;

        public string Type1 { get; set; } = string.Empty;

        public string Type2 { get; set; } = string.Empty;

        public int BaseHP { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvHP { get; set; }

        public int HP  => (int)((2 * (double)BaseHP + (double)EvHP) * (double)Level / 100 + (double)Level + 10);

        public int BaseAttack { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvAttack { get; set; }

        public int Attack => (int)((2 * (double)BaseAttack + (double)EvAttack) * (double)Level / 100 + 5);

        public int BaseDefense { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvDefense { get; set; }

        public int Defense => (int)((2 * (double)BaseDefense + (double)EvDefense) * (double)Level / 100 + 5);

        public int BaseSpecialAttack { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvSpecialAttack { get; set; }

        public int SpecialAttack => (int)((2 * (double)BaseSpecialAttack + (double)EvSpecialAttack) * (double)Level / 100 + 5);

        public int BaseSpecialDefense { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvSpecialDefense { get; set; }

        public int SpecialDefense => (int)((2 * (double)BaseSpecialDefense + (double)EvSpecialDefense) * (double)Level / 100 + 5);

        public int BaseSpeed { get; set; }

        [Range(MinEvPerStat, MaxEvPerStat, ErrorMessage = EVLenghtMessage)]
        public int EvSpeed { get; set; }

        public int Speed => (int)((2 * (double)BaseSpeed + (double)EvSpeed) * (double)Level / 100 + 5);

        public int Generation { get; set; }

        public int AbilityId { get; set; }

        public IEnumerable<AbilityServiceModel> Abilities { get; set; } = new List<AbilityServiceModel>();

        public List<int> MoveIds { get; set; } = new List<int>();
       
        public IEnumerable<MoveServiceModel> Moves { get; set; } = new List<MoveServiceModel>();
    }
}
