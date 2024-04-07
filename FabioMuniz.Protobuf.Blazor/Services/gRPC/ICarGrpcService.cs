using FabioMuniz.Protobuf.Blazor.Models;

namespace FabioMuniz.Protobuf.Blazor.Services.gRPC;

public interface ICarGrpcService
{
	Task<IEnumerable<Car>> GetAllCars();
}