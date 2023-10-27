using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.IServices;

var builder = WebApplication.CreateBuilder(args);
// webapplica.. me permite no tener que escribir public etc 

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DiscotequeContext>(
    opt=>opt.UseInMemoryDatabase("Discoteque")
);

//inyeccion de dependencia 
//significa que no necesito hacer new cada vez .. son new reutilizables la instancia se crea una sola vez
//hay varias por ejemplo el adsigleton que la deja creada de una por eje
// ascoped solo instacia si lo necesito
builder.Services.AddScoped<IArtistService>();

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
