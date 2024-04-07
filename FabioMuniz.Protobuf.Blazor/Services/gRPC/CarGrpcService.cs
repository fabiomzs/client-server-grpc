using FabioMuniz.Protobuf.API.Services.gRPC;
using FabioMuniz.Protobuf.Blazor.Models;

namespace FabioMuniz.Protobuf.Blazor.Services.gRPC;

public class CarGrpcService : ICarGrpcService
{
    private readonly ILogger<CarGrpcService> _logger;
    private readonly CarGrpc.CarGrpcClient _carGrpcClient;

	public CarGrpcService(ILogger<CarGrpcService> logger, CarGrpc.CarGrpcClient carGrpcClient)
	{
		_logger = logger;
		_carGrpcClient = carGrpcClient;
	}

	public async Task<IEnumerable<Car>> GetAllCars()
	{
		_logger.LogInformation("client gprc get all cars...");

		var cars = new List<Car>();

		var response = await _carGrpcClient.GetAllCarsAsync(new CarRequest());

		foreach (var car in response.Data)
			cars.Add(new Car
			{
				Model = car.Model,
				Fuel = car.Fuel,
				Manufacturer = car.Manufacturer,
				Type = car.Type,
				Vin = car.Vin
			});

		return cars;
	}
}
