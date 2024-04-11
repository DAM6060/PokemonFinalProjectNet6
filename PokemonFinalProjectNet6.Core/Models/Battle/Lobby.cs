using PokemonFinalProjectNet6.Core.Models.Player;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class Lobby
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public PlayerServiceModel Player1 { get; set; } = null!;
        public BattleTeamServiceModel TeamP1 { get; set; } = null!;
        public PlayerServiceModel Player2 { get; set; } = null!;
        public BattleTeamServiceModel TeamP2 { get; set; } = null!;
        public List<string> playerMessages { get; set; } = new List<string>();
        public List<string> battleLog { get; set; } = new List<string>();

    }
}
