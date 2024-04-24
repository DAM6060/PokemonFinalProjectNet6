using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Attributes;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Player;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Controllers
{
    public class PlayerController : BaseController
    {
        private readonly ILogger logger;
        private readonly IPlayerService playerService;

        public PlayerController(
                       ILogger<PlayerController> _logger,
                       IPlayerService _playerService)
        {
            playerService = _playerService;
            logger = _logger;
        }
        [HttpGet]
        [AllowAnonymous]
        [MustNotBePlayerAttribute]
        public IActionResult Become()
        {
            var model = new PlayerFormModel();

            return View(model);
        }
        [HttpPost]
		[AllowAnonymous]
		[MustNotBePlayerAttribute]
		public async Task<IActionResult> Become(PlayerFormModel model)
        {
            if(await playerService.UserWithNameExistsAsync(model.Name))
            {
                ModelState.AddModelError(nameof(PlayerFormModel.Name), "Player already exists.");
            }
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            var playerId = playerService.CreateAsync(User.Id(), model.Name);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
