using Microsoft.AspNetCore.SignalR.Client;
using PokemonFinalProjectNet6.Core.Models.Player;

namespace PokemonFinalProjectNet6.Core.Models.Battle
{
    public class LobbyServiceModel
    {
        public int Id { get; set; }
        public List<PlayerServiceModel> Players { get; set; } = new List<PlayerServiceModel>();
        public List<BattleTeamServiceModel?> Teams { get; set; } = new List<BattleTeamServiceModel?>();        
        public List<string> playerMessages { get; set; } = new List<string>();
        public List<string> battleLog { get; set; } = new List<string>();
       


    }
}
