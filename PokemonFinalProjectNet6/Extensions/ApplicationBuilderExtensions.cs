using Microsoft.AspNetCore.Identity;
using static PokemonFinalProjectNet6.Areas.Admin.AdminConstants;
namespace Microsoft.AspNetCore.Builder 
{ 
	public static class ApplicationBuilderExtensions
	{
		public static async Task CreatAdminRoleAsync(this IApplicationBuilder app)
		{
			using var scope = app.ApplicationServices.CreateScope();
			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(AdministratorRoleName)== false)
			{
				var role = new IdentityRole(AdministratorRoleName);
				await roleManager.CreateAsync(role);

				var admin = await userManager.FindByNameAsync("DimitarAdmin@admin.com");

				if(admin != null)
				{
					await userManager.AddToRoleAsync(admin, role.Name);
				}
			}
		}
	}
}
