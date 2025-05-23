﻿using Core.DataAccess.Entities;

namespace MediBookAPI.Model.Entities;

public sealed class Doctor:Entity<int>
{
    public Doctor()
    {
        FirstName=string.Empty;
        LastName=string.Empty;
        Specialty=string.Empty;
        Hospital=new Hospital();
        Appointments=new HashSet<Appointment>();
    }
 
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Specialty { get; set; }  // Uzmanlık Alanı

    public int? HospitalId { get; set; }

    public Hospital Hospital { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}
