using GameStore.Api;
using GameStore.Api.Dtos;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGamesEndpoints();



app.Run();
