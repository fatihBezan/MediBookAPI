using MediBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediBookAPI.DataAccess.Configurations;

public sealed class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
{
    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        builder.ToTable("Hospitals").HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
        builder.Property(x => x.Address).HasColumnName("Address").IsRequired().HasMaxLength(200);
        builder.Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(50);
        builder.Property(x => x.CreatedTime).HasColumnName("CreatedTime").IsRequired();

        builder.HasMany(x => x.Doctors)
            .WithOne(x => x.Hospital)
            .HasForeignKey(x => x.HospitalId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(new[]
        {
            new 
            {
                Id = 1, 
                Name = "Medipol Hastanesi",
                Address = "Bağcılar",
                City = "İstanbul",
                CreatedTime = DateTime.UtcNow
            }
        });
    }
} 