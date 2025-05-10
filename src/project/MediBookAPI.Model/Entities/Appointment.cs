using Core.DataAccess.Entities;

namespace MediBookAPI.Model.Entities;

public sealed class Appointment : Entity<int>
{
    public Appointment()
    {
        Notes = string.Empty;
        Doctor = new Doctor();
        Patient = new Patient();
    }

    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Notes { get; set; }

    // Navigation Properties
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
}
