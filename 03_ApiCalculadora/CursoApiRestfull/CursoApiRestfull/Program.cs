using CursoApiRestfull.Model.Context;
using CursoApiRestfull.Services;
using CursoApiRestfull.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SqlContext>(options => options
.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CursoApiRestfull;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));


//var connection =  Configuration["SqlConection: SqlConectionString"];

builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
