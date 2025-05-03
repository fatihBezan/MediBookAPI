

using MediBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediBookAPI.DataAccess.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.Navigation(x => x.Doctor).AutoInclude();
        builder.Navigation(x=>x.Patient).AutoInclude();
    }
}
