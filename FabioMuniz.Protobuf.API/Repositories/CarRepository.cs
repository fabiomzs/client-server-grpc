using Bogus;
using FabioMuniz.Protobuf.API.Models;

namespace FabioMuniz.Protobuf.API.Repositories;

public class CarRepository : ICarRepository
{
	private readonly ILogger<CarRepository> _logger;

    public CarRepository(ILogger<CarRepository> logger)
    {
        _logger = logger;
    }
    public IEnumerable<Car> GetAllCars()
	{
		_logger.LogInformation("repository generate fake cars...");

		var faker = new Faker<Car>("pt_BR")
			.StrictMode(true)
			.RuleFor(p => p.Model, f => f.Vehicle.Model())
			.RuleFor(p => p.Fuel, f => f.Vehicle.Fuel())
			.RuleFor(p => p.Manufacturer, f => f.Vehicle.Manufacturer())
			.RuleFor(p => p.Type, f => f.Vehicle.Type())
			.RuleFor(p => p.Vin, f => f.Vehicle.Vin());

		var cars = faker.Generate(1000);

		return cars;
	}
}
