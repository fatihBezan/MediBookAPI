namespace MediBookAPI.Model.Dtos.Appointments;

public sealed class AppointmentAddRequestDto
{
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Notes { get; set; } = string.Empty;
}
