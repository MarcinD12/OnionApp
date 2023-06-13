using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OnionApi.Identity;
using OnionCore.Interfaces;
using OnionInfrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle




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
builder.Services.AddScoped<IPartService, PartService>();

builder.Services.AddTransient<IEFWarehouseRepository, DatabaseContext>();
builder.Services.AddScoped<IWarehouseService, WarehouseService>();
//identity

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("requireadmin", policy =>
        policy.RequireRole("admin"));
    options.AddPolicy("requireuser", policy => policy.RequireRole("user"));
});
builder.Services.AddSingleton<JwtSettings>();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(new JwtSettings(builder.Configuration));
builder.Services.ConfigureCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.
              Enter 'Bearer' and then your token in the text input below.
              Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Todos API",
    });
});

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();

app.UseAuthorization();


app.Run();
