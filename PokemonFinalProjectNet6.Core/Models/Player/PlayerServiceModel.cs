using Microsoft.AspNetCore.SignalR.Client;

namespace PokemonFinalProjectNet6.Core.Models.Player
{
	public class PlayerServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public HubConnection? Connection { get; set; }


        
    }
}
