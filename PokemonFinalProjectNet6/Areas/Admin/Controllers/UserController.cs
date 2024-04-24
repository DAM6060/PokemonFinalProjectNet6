using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Admin.User;
using static PokemonFinalProjectNet6.Areas.Admin.AdminConstants;

namespace PokemonFinalProjectNet6.Areas.Admin.Controllers
{
	public class UserController : AdminController
	{
		private readonly IUserService userService;
		private readonly IMemoryCache memoryCache;

		public UserController(IUserService _userService, IMemoryCache _memoryCache)
		{
			userService = _userService;
			memoryCache = _memoryCache;
		}
		public async Task<IActionResult> All()
		{
			var model = memoryCache.Get<IEnumerable<UserServiceModel>>(UsersCacheKey);

			if (model == null || model.Any() == false)
			{
				model = await userService.AllAsync();

				var cacheOptions = new MemoryCacheEntryOptions()
					.SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

				memoryCache.Set(UsersCacheKey, model, cacheOptions);
			}

			return View(model);
		}
	}
}
