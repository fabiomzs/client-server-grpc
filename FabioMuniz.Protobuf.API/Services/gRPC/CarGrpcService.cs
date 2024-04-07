using FabioMuniz.Protobuf.API.Repositories;
using Grpc.Core;

namespace FabioMuniz.Protobuf.API.Services.gRPC;

public class CarGrpcService : CarGrpc.CarGrpcBase
{
    private readonly ILogger<CarGrpcService> _logger;
    private readonly ICarRepository _carRepository;
    public CarGrpcService(ILogger<CarGrpcService> logger, ICarRepository carRepository)
    {
        _logger = logger;
        _carRepository = carRepository;
    }

	public override Task<CarResponse> GetAllCars(CarRequest request, ServerCallContext context)
	{
        _logger.LogInformation("server grpc...");

        var cars = _carRepository.GetAllCars();

        var response = new CarResponse();

        foreach (var car in cars)
        {
            response.Data.Add(new Cars
            {
                Model = car.Model,
                Fuel = car.Fuel,
                Manufacturer = car.Manufacturer,
                Type = car.Type,
                Vin = car.Vin
            });
        }


        return Task.FromResult(response);
	}
}
