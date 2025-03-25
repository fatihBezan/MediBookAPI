﻿
using Core.DataAccess.Entities;

namespace MediCareAPI.Model.Entities;

public sealed class Patient:Entity<int>
{

    public Patient()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Appointments = new HashSet<Appointment>();

    }
    
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public ICollection<Appointment> Appointments { get; set; }

}
