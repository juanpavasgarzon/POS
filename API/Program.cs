using API.Extensions;
using Pavas.Patterns.Cqrs.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => options.EnableAnnotations());
builder.Services.AddCqrs();
builder.Logging.AddConsole();

var app = builder.Build();

app.MapEndpoints();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();