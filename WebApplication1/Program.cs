using WebApplication1;
using WebApplication1.Infrastructure;
using WebApplication1.Models;
using WebApplication1.RepoImplementation;
using WebApplication1.RepoImplementation.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager<MyDbContext>>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddTransient<IRepository<MyTestEntity>, MyTestEntityRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
