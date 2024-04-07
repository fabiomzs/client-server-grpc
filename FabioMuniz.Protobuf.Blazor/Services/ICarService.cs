using FabioMuniz.Protobuf.Blazor.Models;

namespace FabioMuniz.Protobuf.Blazor.Services;

public interface ICarService
{
	Task<IEnumerable<Car>> GetAllCars();
}
