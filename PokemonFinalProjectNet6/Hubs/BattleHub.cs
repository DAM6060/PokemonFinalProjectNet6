using Microsoft.AspNetCore.SignalR;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Hubs
{
    public class BattleHub : Hub
    {
        private readonly IBattleService battleService;
        private readonly ILobbyService lobbyService;

        public BattleHub(IBattleService _battleService,
            ILobbyService _lobbyService)
        {
            battleService = _battleService;
            lobbyService = _lobbyService;
        }

		public override Task OnConnectedAsync()
		{
            var lobby = GetLobbyForPlayer(Context.ConnectionId);
			return base.OnConnectedAsync();
		}
        private Lobby GetLobbyForPlayer(string connectionId)
        {
			return null;
		}






	}
}
