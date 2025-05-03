using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Contexts;

public sealed class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
    {
       
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(@"server=ASUS\SQLEXPRESS; Database=MediBookAPI_Db;Trusted_connection=true;TrustServerCertificate=True;");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Appointment> Appointments { get; set; } = null!;

    public DbSet<Patient> Patients { get; set; } = null!;

    public DbSet<Hospital> Hospitals { get; set; } = null!;

    public DbSet<Doctor> Doctors { get; set; } = null!;

    public DbSet<User> Users { get; set; } = null!;

    public DbSet<UserRole> UserRoles { get; set; } = null!;

    public DbSet<Role> Roles { get; set; } = null!;
}
