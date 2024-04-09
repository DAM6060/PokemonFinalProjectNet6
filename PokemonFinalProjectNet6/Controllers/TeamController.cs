using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonFinalProjectNet6.Core.Models.Team;

namespace PokemonFinalProjectNet6.Controllers
{
    public class TeamController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new TeamFormModel();
            {
                //Need to add the logic to get the list of Pokemon for dropdown
                //need abilities and moves
                //Make into a 3 stage process First stage is to select the pokemon
                //This will be a dropdown list of all the pokemon
                //3 drpodown fields for the pokemon to send a request to get those base value stats
                //In the second stage we need to return the base stats of the pokemon drop down for ability and moves to select
                //and Finally post
                //So this sounds like 2 get requests and 1 post request
                //so in this model we need to have a list of pokemon, abilities, and moves
                //or just a list of pokemon and then we can get the abilities and moves from the pokemon
            }
            return View();
        }
    }
}
