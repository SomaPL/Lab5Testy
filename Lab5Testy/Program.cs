using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lab5Testy.Data;
using Lab5Testy;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Lab5TestyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lab5TestyContext") ?? throw new InvalidOperationException("Connection string 'Lab5TestyContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<TaskManager>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
