using MediBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediBookAPI.DataAccess.Configurations;

public sealed class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.ToTable("Appointments").HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.DoctorId).HasColumnName("DoctorId").IsRequired();
        builder.Property(x => x.PatientId).HasColumnName("PatientId").IsRequired();
        builder.Property(x => x.AppointmentDate).HasColumnName("AppointmentDate").IsRequired();
        builder.Property(x => x.Notes).HasColumnName("Notes").IsRequired();
        builder.Property(x => x.CreatedTime).HasColumnName("CreatedTime").IsRequired();

        builder.HasOne(x => x.Doctor)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.DoctorId);

        builder.HasOne(x => x.Patient)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.PatientId);

        // AutoInclude navigation properties
        builder.Navigation(x => x.Doctor).AutoInclude();
        builder.Navigation(x => x.Patient).AutoInclude();
    }
}
