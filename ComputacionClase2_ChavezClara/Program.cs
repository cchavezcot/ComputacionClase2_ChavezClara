using ComputacionClase2_ChavezClara.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ModelDBContext>(options =>
{
    var connectionStr = builder.Configuration.GetConnectionString("Computacion") ??
        throw new Exception("Connetion string 'Computacion' not found");

    options.UseSqlServer(connectionStr);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Utilizacion de la conexion y creacion de base de datos.
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<ModelDBContext>();
    context.Database.EnsureDeleted(); //Eliminar Base de datos. Hasta que veamos migraciones
    context.Database.EnsureCreated();
}

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
