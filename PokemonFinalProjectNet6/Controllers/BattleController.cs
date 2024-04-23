using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using PokemonFinalProjectNet6.Attributes;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Hubs;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Controllers
{
    
    public class BattleController : BaseController
    {
        private readonly IBattleService battleService;
        private readonly IPlayerService playerService;
        private readonly ILobbyService lobbyService; 
        private readonly IHubContext<BattleHub> battleHubContext;
        private readonly ITeamService teamService;
        
        public BattleController(
            IBattleService _battleService,
            IPlayerService _playerService,
            ILobbyService _lobbyService,
            ITeamService _teamService)
        {
            battleService = _battleService;
            playerService = _playerService;
            lobbyService = _lobbyService;
            teamService = _teamService;

        }
        [HttpGet]
		[MustBePlayer]
		public async Task<IActionResult> TeamSelect()
        {
            var playerId = await playerService.GetPlayerIdAsync(User.Id());

            var teams = await teamService.GetTeamsByPlayerIdForBattleAsync((int)playerId);

            var model = new PlayerTeamsServiceModel
            {
				Teams = teams
			};

            return View(model);
        }
        [HttpPost]
		[MustBePlayer]
		public async Task<IActionResult> TeamSelect(int teamId)
        {
            var playerId = await playerService.GetPlayerIdAsync(User.Id());           

            if (await teamService.ExistsById(teamId) == false)
            {
                return BadRequest();
            }

            if (await teamService.PlayerHasTeamAsync(teamId, (int)playerId) == false)
            {
				return Unauthorized();
			}

            return RedirectToAction(nameof(LaunchBattle),new {teamId, playerId});            
        }
		[MustBePlayer]
		public async Task<IActionResult> LaunchBattle(int teamId, int playerId) 
        {
            int lobbyId =  await lobbyService.JoinLobbyAsync(teamId, playerId);

            var lobby = await lobbyService.GetLobbyByIdAsync(lobbyId);

            await ConnectUserToHub(lobby.Players.Where(x => x.Id ==playerId).First());

            return Ok();           
        
        }
		//public Task<IActionResult> MakeMove()
		//{
		//
		//}
		//public Task<IActionResult> EndBattle()
		//{
		//
		//}
		
		private async Task ConnectUserToHub(PlayerServiceModel player)
        {
			var hubConnection = new HubConnectionBuilder().WithAutomaticReconnect().Build();
			await hubConnection.StartAsync();
			player.Connection = hubConnection;
		}

        

        
    }
}
