using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Core.Models.Player
{
    public class PlayerTeamsServiceModel
    {
        public int Id { get; set; }
        public IEnumerable<TeamServiceModel> Teams { get; set; } = new List<TeamServiceModel>();
    }
}
