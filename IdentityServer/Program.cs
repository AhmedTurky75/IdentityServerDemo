using IdentityServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
	  .AddInMemoryApiScopes(Config.ApiScopes)
	  .AddInMemoryClients(Config.Clients)
	  .AddTestUsers(Config.TestUsers);


var app = builder.Build();

app.UseIdentityServer();
app.MapGet("/", () => "Hello World!");

app.Run();
