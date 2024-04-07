using FabioMuniz.Protobuf.API.Application.Queries;
using FabioMuniz.Protobuf.API.Repositories;

namespace FabioMuniz.Protobuf.API.Extensions;

public static class DependencyInjectionExtension
{
	public static void RegisterServices(this IServiceCollection services)
	{
		services.AddSingleton<ICarQueries, CarQueries>();
		services.AddSingleton<ICarRepository, CarRepository>();
	}
}
