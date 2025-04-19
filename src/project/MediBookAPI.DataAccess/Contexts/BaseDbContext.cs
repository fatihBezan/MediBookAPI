

using MediCareAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;


namespace MediCareAPI.DataAccess.Contexts;

public sealed class BaseDbContext:DbContext
{


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(@"server=ASUS\SQLEXPRESS; Database=MediBookAPI_Db;Trusted_connection=true;TrustServerCertificate=True;");
    //}

    public DbSet<Appointment> Appointments { get; set; }

    public DbSet<Patient> Patients { get; set; }

    public DbSet<Hospital> Hospitals { get; set; }

    public DbSet<Doctor> Doctors { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<UserRole> UserRoles { get; set; }

    public DbSet<Role> Roles { get; set; }

}
