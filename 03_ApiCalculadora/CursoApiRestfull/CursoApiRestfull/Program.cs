using CursoApiRestfull.Model.Context;
using Microsoft.EntityFrameworkCore;
using CursoApiRestfull.Repository;
using CursoApiRestfull.Repository.Implementations;
using CursoApiRestfull.Business.Implementations;
using CursoApiRestfull.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SqlContext>(options => options
.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CursoApiRestfull;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

builder.Services.AddApiVersioning();    
//var connection =  Configuration["SqlConection: SqlConectionString"];

builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
