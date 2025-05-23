﻿using Core.DataAccess.Entities;

namespace MediBookAPI.Model.Entities;

public sealed class Hospital : Entity<int>
{
    public Hospital()
    {
        Name = string.Empty;
        Address = string.Empty;
        City = string.Empty;
        Doctors = new HashSet<Doctor>();
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    // Navigation Property
    public ICollection<Doctor> Doctors { get; set; }
}
