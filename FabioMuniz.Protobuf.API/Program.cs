using FabioMuniz.Protobuf.API.Extensions;
using FabioMuniz.Protobuf.API.Routes;
using FabioMuniz.Protobuf.API.Services.gRPC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGrpc();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseGrpcWeb();
app.MapGrpcService<CarGrpcService>().EnableGrpcWeb();

app.MapCarRoutes();

app.Run();
