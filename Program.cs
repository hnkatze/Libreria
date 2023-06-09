using libreria;
using libreria.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configurar DataBase
var connectionString = "Data Source=localhost,1433; Initial Catalog=LibreriaDB; user ID=SA; Password=C@m1l1t0*; TrustServerCertificate=True";
builder.Services.AddDbContext<libreriaContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSqlServer<libreriaContext>("Data Source=localhost,1433; Initial Catalog=LibreriaDB; user ID=SA; Password=C@m1l1t0*; TrustServerCertificate=True");
builder.Services.AddScoped<IAutorService, AutorService>();//contrucctor de servicios
builder.Services.AddScoped<IGeneroService, GeneroService>();
builder.Services.AddScoped<ILibroService, LibroService>();

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
