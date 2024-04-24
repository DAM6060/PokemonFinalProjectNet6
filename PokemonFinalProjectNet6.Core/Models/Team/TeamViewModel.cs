using PokemonFinalProjectNet6.Core.Models.Pokemon;

namespace PokemonFinalProjectNet6.Core.Models.Team
{
	public class TeamViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public int PlayerId { get; set; }

		public List<PokemonViewModel> Pokemons { get; set; } = new List<PokemonViewModel>();

		public int Wins { get; set; }

		public int Losses { get; set; }
	}
}
