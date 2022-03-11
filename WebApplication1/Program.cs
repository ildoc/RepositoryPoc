using WebApplication1;
using WebApplication1.Infrastructure;
using WebApplication1.Models;
using WebApplication1.UoWImplementation.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddLogging();

// questo per tutti
builder.Services.AddScoped<IUnitOfWork, UnitOfWork<MyDbContext>>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

// questo solo per le entity di cui si intende fare override
builder.Services.AddTransient<IRepository<MyTestEntity>, MyTestEntityRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
