using Microsoft.EntityFrameworkCore;
using GestorGastos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GestorGastosDB;Trusted_Connection=True;"));

// EL CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy.AllowAnyOrigin()    // Permite peticiones de cualquier página web
              .AllowAnyHeader()    // Para usar cualquier tipo de dato
              .AllowAnyMethod();   // Para usar GET, POST, PUT, DELETE
    });
});

// Agrega los servicios por defecto de la API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura el entorno HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ACTIVAR EL CORS
app.UseCors("PermitirTodo");

app.UseAuthorization();
app.MapControllers();

app.Run();