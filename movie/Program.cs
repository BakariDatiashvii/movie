using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using movie.DBcontex;
using movie.Services.FIlmebiServices;
using movie.Services.FilmMsaxiobebiServices;
using movie.Services.MsaxiobebiServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IFilmebiServices, FilmebiServices>();
builder.Services.AddScoped<IMsaxiobebiServices, MsaxiobebiServices>();
builder.Services.AddScoped<IFilmMsaxioebebiServices, FilmMsaxioebebiServices>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FilmMsaxiobiDBcontext>(option =>
{
    option.UseSqlServer(@"Server=DESKTOP-MRACR18\SQLEXPRESS01;Database=MOVIE;Trusted_Connection=True;TrustServerCertificate=True;");
});

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
