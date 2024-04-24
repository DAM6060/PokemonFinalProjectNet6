using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Admin.User;
using PokemonFinalProjectNet6.Infrastructure.Data.Common;
using PokemonFinalProjectNet6.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFinalProjectNet6.Core.Services
{
	public class UserService: IUserService
	{
		private readonly IRepository repository;

		public UserService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task<IEnumerable<UserServiceModel>> AllAsync()
		{
			return await repository.AllAsReadOnly<IdentityUser>()
				.Select(u => new UserServiceModel
				{
					Email = u.Email,
					Username = u.UserName,
					PlayerName = repository.AllAsReadOnly<Player>()
						.Where(Player => Player.UserId == u.Id)
						.Select(Player => Player.Name)
						.FirstOrDefault()

				}).ToListAsync();
				
		}
	}
}
