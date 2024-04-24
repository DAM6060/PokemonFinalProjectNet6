using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Abilitiy;

namespace PokemonFinalProjectNet6.Controllers
{
    public class AbilityController : BaseController
    {
        private readonly IAbilityService abilityService;

        public AbilityController(IAbilityService _abilityService)
        {
            abilityService = _abilityService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AbilityQueryModel model)
        {
            var abilities = await abilityService.AllAbilitiesSearch(
                               model.SearchTerm,
                               model.Sorting,
                               model.CurrentPage,
                               model.ItemsPerPage);

            model.Abilities = abilities.Abilities;
            model.TotalItemsCount = abilities.TotalItemsCount;
            model.CurrentPage = abilities.CurrentPage;
            return View(model);
        }
    }
}
