using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Service.Mappers;
using MediBookAPI.Service.Mappers.Categories;
using MediBookAPI.Service.Mappers.Profiles;
using MediBookAPI.DataAccess.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MediBookAPI.Service.Helpers;
using MediBookAPI.Service.Concretes;
using MediBookAPI.DataAccess.Repositories.Concretes;
using MediBookAPI.Service.Mappers.Doctors;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IAppointmentRepository,AppointmentRepository>();
builder.Services.AddScoped<IAppointmentMapper,AppointmentAutoMapper>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IDoctorMapper,DoctorAutoMapper>();
builder.Services.AddScoped<ICloudinaryHelper, CloudinaryHelper>();


builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));


builder.Services.AddControllers();
builder.Services.AddDbContext<BaseDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});

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
