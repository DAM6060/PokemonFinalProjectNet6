using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Hubs;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Controllers
{
    public class BattleController : BaseController
    {
        private readonly IBattleService battleService;
        private readonly IPlayerService playerService;
        private readonly ILobbyService lobbyService; // This will be used to start a battle and matching players
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
        public async Task<IActionResult> TeamSelect(int teamId)
        {
            var team = await teamService.GetBattleTeamServiceByIdAsync(teamId);

            return RedirectToAction();            
        }        
        
        //public Task<IActionResult> LaunchBattle() 
        //{
        //    int lobbyId = lobbyService.JoinLobby();
        //
        //}
        //public Task<IActionResult> MakeMove()
        //{
        //
        //}
        //public Task<IActionResult> EndBattle()
        //{
        //
        //}
        

        
    }
}
