using PokemonFinalProjectNet6.Core.Enumerations;
using PokemonFinalProjectNet6.Core.Models.Paging;

namespace PokemonFinalProjectNet6.Core.Models.Team
{
    public class TeamLeaderBoardQueryModel : PagingModel
    { 

        public string PokemonFiltering { get; init; } = string.Empty;

        public IEnumerable<string> PokemonNames { get; set; } = new List<string>();

        public TeamSorting Sorting { get; init; }

        public IEnumerable<TeamServiceModel> Teams { get; set; } = new List<TeamServiceModel>();


    }
}
