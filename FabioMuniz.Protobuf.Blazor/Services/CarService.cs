using FabioMuniz.Protobuf.Blazor.Models;

namespace FabioMuniz.Protobuf.Blazor.Services;

public class CarService : ICarService
{
    private readonly ILogger<CarService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public CarService(ILogger<CarService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;        
    }

    public async Task<IEnumerable<Car>> GetAllCars()
	{
        _logger.LogInformation("client rest get all cars...");

        using HttpClient httpClient = _httpClientFactory.CreateClient(Configuration.Api.HttpClientName);

        var response = await httpClient.GetFromJsonAsync<CarsResponse>("api/cars");

        return response!.Data;
	}
}