using Ocelot.DependencyInjection; //For Dependency Injection
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
.AddEnvironmentVariables();
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();
await app.UseOcelot();
// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

app.Run();
