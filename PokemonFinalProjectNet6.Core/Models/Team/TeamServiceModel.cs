namespace PokemonFinalProjectNet6.Core.Models.Team
{
	public class TeamServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int PlayerId { get; set; }

        public List<string> Pokemons { get; set; } = new List<string>();

        public int Wins { get; set; }

        public int Losses { get; set; }

        
    }
}
