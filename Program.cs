using forestTrack.Data;
using forestTrack.Data.Interface;
using forestTrack.Data.repository;
using forestTrack.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IequipmentRepository,EquipmentRepository>();
builder.Services.AddTransient<IEquipmentStateRepository, EquipmentStateRepository>(); 

builder.Services.AddTransient<IEquipmentModelRepository, EquipmentModelRepository>(); 




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
