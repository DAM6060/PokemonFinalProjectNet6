using PokemonFinalProjectNet6.Core.Models.Admin.User;

namespace PokemonFinalProjectNet6.Core.Contracts
{
	public interface IUserService
	{
		public Task<IEnumerable<UserServiceModel>> AllAsync();
	}
}
