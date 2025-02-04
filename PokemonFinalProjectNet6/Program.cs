using PokemonFinalProjectNet6.Hubs;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);


builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddApplicationServices();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
	
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapHub<LobbyHub>("/lobbyHub");

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
						name: "Areas",
						pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
	endpoints.MapControllerRoute(
				name: "default",
						pattern: "{controller=Home}/{action=Index}/{id?}");
	
	
	endpoints.MapRazorPages();
});

await app.CreatAdminRoleAsync();
await app.RunAsync();
