using FabioMuniz.Protobuf.API.Models;

namespace FabioMuniz.Protobuf.API.Repositories;

public interface ICarRepository
{
	public IEnumerable<Car> GetAllCars();
}
