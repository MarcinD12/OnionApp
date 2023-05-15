using Microsoft.EntityFrameworkCore;
using OnionInfrastructure;
using Microsoft.Extensions.DependencyInjection;
using OnionCore;
using Application;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var conString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<EFOrderRepository>(options=> {
    options.UseSqlite(conString,b=>b.MigrationsAssembly("OnionApi"));
    
    }
   );
builder.Services.AddDbContext<EFPartRepository>(options => {
    options.UseSqlite(conString, b => b.MigrationsAssembly("OnionApi"));

}
   );
builder.Services.AddDbContext<EFProductRepository>(options => {
    options.UseSqlite(conString, b => b.MigrationsAssembly("OnionApi"));

}
   );
builder.Services.AddTransient<IEFProductRepository, EFProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddTransient<IEFPartRepository,EFPartRepository>();
builder.Services.AddScoped<IPartService,PartService>();

builder.Services.AddTransient<IEFOrderRepository, EFOrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();


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
