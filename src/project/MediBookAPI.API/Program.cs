using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Service.Mappers;
using MediCareAPI.DataAccess.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IAppointmentService,IAppointmentService>();
builder.Services.AddScoped<IAppointmentRepository,IAppointmentRepository>();
builder.Services.AddScoped<AppointmentMapper>();


builder.Services.AddDbContext<BaseDbContext>();

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
