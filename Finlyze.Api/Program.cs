using Finlyze.Api.Configuration.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDependence(builder.Configuration);

var app = builder.Build();



app.Run();
