using FabioMuniz.Protobuf.API.Services.gRPC;
using FabioMuniz.Protobuf.Blazor.Services;
using FabioMuniz.Protobuf.Blazor.Services.gRPC;

namespace FabioMuniz.Protobuf.Blazor.Extensions;

public static class DependencyInjectionExtension
{
	public static void RegisterServices(this IServiceCollection services)
	{
		services.AddHttpClient(Configuration.Api.HttpClientName, client => client.BaseAddress = new Uri(Configuration.Api.UrlBase));	

		services.AddSingleton<ICarService, CarService>();
		services.AddScoped<ICarGrpcService, CarGrpcService>();

		services.AddGrpcClient<CarGrpc.CarGrpcClient>(options =>
		{
			options.Address = new Uri(Configuration.Api.UrlBase);
		});
	}
}
