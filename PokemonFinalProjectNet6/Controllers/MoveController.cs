using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Contracts;
using PokemonFinalProjectNet6.Core.Models.Abilitiy;
using PokemonFinalProjectNet6.Core.Models.Move;
using PokemonFinalProjectNet6.Core.Services;

namespace PokemonFinalProjectNet6.Controllers
{
    public class MoveController : BaseController
    {
        private readonly IMoveService moveService;

        public MoveController(IMoveService _moveService)
        {
            moveService = _moveService;
        }
        
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]MoveQueryModel model)
        {
            var moves = await moveService.AllMovesSearch(
                               model.SearchTerm,
                               model.TypeFilter,
                               model.DamageClassFilter,
                               model.Sorting,
                               model.CurrentPage,
                               model.ItemsPerPage);

            model.Moves = moves.Moves;
            model.TotalItemsCount = moves.TotalItemsCount;
            model.CurrentPage = moves.CurrentPage;
            return View(model);
        }
    }
}
