using MediBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediBookAPI.DataAccess.Configurations;

public sealed class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.ToTable("Patients").HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(x => x.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
        builder.Property(x => x.CreatedTime).HasColumnName("CreatedTime").IsRequired();

        builder.HasMany(x => x.Appointments)
            .WithOne(x => x.Patient)
            .HasForeignKey(x => x.PatientId);

        builder.HasData(
            new Patient 
            { 
                Id = 1, 
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                BirthDate = new DateTime(1990, 1, 1),
                CreatedTime = DateTime.UtcNow
            }
        );
    }
} 