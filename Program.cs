using Microsoft.EntityFrameworkCore;

using MyWebAPI.Models;
using MyWebAPI.Repositories;
using MyWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StreamingContext>(
    opt => opt.UseInMemoryDatabase("mydb")
);

builder.Services.AddScoped<IChannelRepository, ChannelRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();