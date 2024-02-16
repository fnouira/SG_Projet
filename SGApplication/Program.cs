using Microsoft.EntityFrameworkCore;
using SGApplication.Data.Context;
using SGApplication.Repository;
using SGApplication.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBoissonsRepository, BoissonRepository>();
builder.Services.AddScoped<IBoissonsService, BoissonsService>();
builder.Services.AddDbContext<BoissonsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("localDb"));
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
