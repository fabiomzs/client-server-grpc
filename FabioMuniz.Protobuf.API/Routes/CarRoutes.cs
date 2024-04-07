using FabioMuniz.Protobuf.API.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace FabioMuniz.Protobuf.API.Routes;

public static class CarRoutes
{
    public static WebApplication MapCarRoutes(this WebApplication app)
    {
        var carRoutes = app.MapGroup("/api/cars").WithTags("Cars").WithOpenApi();

        carRoutes.MapGet("/", ([FromServices] ICarQueries carQueries) =>
        {
            return Results.Ok(new { Data = carQueries.GetAllCars() });
        });

        return app;
    }
}
