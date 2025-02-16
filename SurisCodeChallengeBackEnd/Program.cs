using Microsoft.EntityFrameworkCore;
using SurisCodeChallenge.Models;
using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Repositorios.Implementaciones;
using SurisCodeChallenge.Repositorios.Interfaces;
using SurisCodeChallenge.Servicios.Implementaciones;
using SurisCodeChallenge.Servicios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ReservasContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IReservaService, ReservaService>();
builder.Services.AddScoped<IServicioService, ServicioService>();
builder.Services.AddScoped<IRepository<Reserva>, ReservaRepository>();
builder.Services.AddScoped<IRepository<Servicio>, ServicioRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOrigin",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.WebHost.UseUrls("http://localhost:5000");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
