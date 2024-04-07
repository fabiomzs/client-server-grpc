using FabioMuniz.Protobuf.API.Models;

namespace FabioMuniz.Protobuf.API.Application.Queries;

public interface ICarQueries
{
	IEnumerable<Car> GetAllCars();
}
