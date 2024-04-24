using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PokemonFinalProjectNet6.Core.Contracts;
using System.Security.Claims;

namespace PokemonFinalProjectNet6.Attributes
{
	public class MustNotBePlayerAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			base.OnActionExecuting(context);

			IPlayerService? playerService = context.HttpContext.RequestServices.GetService<IPlayerService>();

			if (playerService == null)
			{
				context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
			}

			if (playerService != null && 
								 playerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
			{
				context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
			}

			
		}
	}
	
}
