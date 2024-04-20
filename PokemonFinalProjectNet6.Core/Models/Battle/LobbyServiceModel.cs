using PokemonFinalProjectNet6.Core.Models.Player;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class LobbyServiceModel
    {
        public int Id { get; set; }
        public PlayerServiceModel Player1 { get; set; } = null!;
        public BattleTeamServiceModel TeamP1 { get; set; } = null!;
        public PlayerServiceModel Player2 { get; set; } 
        public BattleTeamServiceModel TeamP2 { get; set; }
        public List<string> playerMessages { get; set; } = new List<string>();
        public List<string> battleLog { get; set; } = new List<string>();


    }
}
