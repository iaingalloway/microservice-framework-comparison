using Microsoft.AspNetCore.Http.Json;
using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<JsonOptions>(options =>
    options.SerializerOptions.TypeInfoResolver = new JsonContext());
var app = builder.Build();

app.MapGet("/", () => new Response(DateTime.UtcNow));

app.MapGet("/health", () => Results.Ok());

app.MapGet("/ready", () => Results.Ok());

app.Run();
