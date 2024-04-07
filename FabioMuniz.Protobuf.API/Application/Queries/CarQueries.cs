using FabioMuniz.Protobuf.API.Models;
using FabioMuniz.Protobuf.API.Repositories;

namespace FabioMuniz.Protobuf.API.Application.Queries;

public class CarQueries : ICarQueries
{
    private readonly ILogger<CarQueries> _logger;
    private readonly ICarRepository _carRepository;
    public CarQueries(ILogger<CarQueries> logger, ICarRepository carRepository)
    {
        _logger = logger;
        _carRepository = carRepository;
    }
    public IEnumerable<Car> GetAllCars()
	{
        _logger.LogInformation("query get all cars...");

		return _carRepository.GetAllCars();
	}
}
