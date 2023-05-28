using Microsoft.EntityFrameworkCore;
using OnionInfrastructure;
using Microsoft.Extensions.DependencyInjection;
using Application;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OnionCore.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var conString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlite(conString, b => b.MigrationsAssembly("OnionApi"));
});



builder.Services.AddTransient<IEFSupplierRepository, DatabaseContext>();
builder.Services.AddScoped<ISupplierService, SupplierService>();

builder.Services.AddTransient<IEFStockRepository, DatabaseContext>();
builder.Services.AddScoped<IStockService, StockService>();

builder.Services.AddTransient<IEFPartRepository, DatabaseContext>();
builder.Services.AddScoped<IPartService,PartService>();

builder.Services.AddTransient<IEFWarehouseRepository, DatabaseContext>();
builder.Services.AddScoped<IWarehouseService, WarehouseService>();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
