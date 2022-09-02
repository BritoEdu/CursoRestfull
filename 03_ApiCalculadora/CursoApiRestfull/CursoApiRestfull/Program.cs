using CursoApiRestfull.Model.Context;
using Microsoft.EntityFrameworkCore;
using CursoApiRestfull.Business.Implementations;
using CursoApiRestfull.Business;
using CursoApiRestfull.Repository.Generic;
using CursoApiRestfull.Hypermedia.Enricher;
using CursoApiRestfull.Hypermedia.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SqlContext>(options => options
.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CursoApiRestfull;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

var filterOptions = new HyperMediaFilterOptions();
filterOptions.ContentResponseEnricherList.Add(new PersonEnricher());
//filterOptions.ContentResponseEnricherList.Add(new BookEnricher());

builder.Services.AddSingleton(filterOptions);


builder.Services.AddApiVersioning();    
//var connection =  Configuration["SqlConection: SqlConectionString"];

//builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<ILivroBusiness, LivroBusinessImplementation>();
//builder.Services.AddScoped<ILivroRepository, LivroRepositoryImplementation>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllerRoute("DefaultApi", "{controller=values}/{id?}");
app.MapControllers();

app.Run();
