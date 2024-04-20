using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Battle;
using PokemonFinalProjectNet6.Core.Models.Player;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;

namespace PokemonFinalProjectNet6.Core.Services
{
    public class LobbyService   
    {
        private readonly IRepository repository;
        private readonly IBattleService battleService;
        
        
        public LobbyService(
            IBattleService _battleService,
            IRepository _repository)
        {
            battleService = _battleService;
            repository = _repository;
            
        }
        
        public Task<int> JoinLobby(BattleTeamServiceModel teamP1, PlayerServiceModel player1)
        {
            // Create a new lobby
            // Add the lobby to the list of lobbies
            // Return true
            //Why Dont we return Lubby loby instead of bool
            //We can return the lobby and then we can use the lobby to start the battle
            //We can also use the lobby to end the battle
            //We can also use the lobby to get the battle log
            //We can also use the lobby to get the player messages

            //I want to create a check which checks if there is a lobby with one player in it and add the current player to that lobby
            //If there is no lobby with one player in it, then create a new lobby and add the player to that lobby











            return null;
        }
        private async Task<bool> ExistsLobbyWithOnePlayer()
        {
            return await Task.FromResult(true);
        }
        
        public Task<bool> StartBattle()
        {
            throw new NotImplementedException();
        }
    }
}
