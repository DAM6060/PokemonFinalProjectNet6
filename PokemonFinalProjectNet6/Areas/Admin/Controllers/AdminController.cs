using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static PokemonFinalProjectNet6.Areas.Admin.AdminConstants;

namespace PokemonFinalProjectNet6.Areas.Admin.Controllers
{
	[Area(AreaName)]
	[Authorize(Roles = AdministratorRoleName)]
	public class AdminController : Controller
	{
		
	}
}
