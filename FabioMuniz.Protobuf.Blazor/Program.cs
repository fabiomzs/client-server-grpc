using FabioMuniz.Protobuf.Blazor;
using FabioMuniz.Protobuf.Blazor.Components;
using FabioMuniz.Protobuf.Blazor.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

Configuration.Api.UrlBase = builder.Configuration.GetSection("AppSettings").GetValue<string>("ApiBaseURL") ?? string.Empty;
Configuration.Api.HttpClientName = builder.Configuration.GetSection("AppSettings").GetValue<string>("ApiHttpClientName") ?? string.Empty;

builder.Services.RegisterServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);	
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
