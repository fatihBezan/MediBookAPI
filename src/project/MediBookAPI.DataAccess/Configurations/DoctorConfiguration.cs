using MediBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace MediBookAPI.DataAccess.Configurations;

public sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.ToTable("Doctors").HasKey(x=>x.Id);
        builder.Property(x=>x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.CreatedTime).HasColumnName("CreatedTime").IsRequired();
        builder.Property(x=>x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
        builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
        builder.Property(x=>x.HospitalId).HasColumnName("HospitalId").IsRequired();
        builder.Property(x=>x.Specialty).HasColumnName("Specialty").IsRequired().HasMaxLength(100);

        builder.HasOne(x => x.Hospital)
            .WithMany(x => x.Doctors)
            .HasForeignKey(x => x.HospitalId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Appointments)
            .WithOne(x => x.Doctor)
            .HasForeignKey(x => x.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(new[]
        {
            new 
            {
                Id = 1,
                CreatedTime = DateTime.UtcNow,
                FirstName = "Furkan",
                LastName = "Duman",
                HospitalId = 1,
                Specialty = "Kardiyoloji"
            },
            new 
            {
                Id = 2,
                CreatedTime = DateTime.UtcNow,
                FirstName = "Hatice",
                LastName = "Duman",
                HospitalId = 1,
                Specialty = "Nöroloji"
            }
        });
    }
}
