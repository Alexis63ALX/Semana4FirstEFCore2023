using Microsoft.EntityFrameworkCore;
using Semana4FirstEFCore.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var _config = builder.Configuration; //puede accerder a cualquier atributo del valor de SQL o archivo JJson
var cnx = _config.GetConnectionString("DevConnection");
builder.Services.AddDbContext<PeruDbContext>
    (options => options.UseSqlServer());


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
