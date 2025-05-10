namespace MediBookAPI.Model.Dtos.Appointments;

public sealed class AppointmentResponseDto
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string DoctorFullName { get; set; } = string.Empty;
    public int PatientId { get; set; }
    public string PatientFullName { get; set; } = string.Empty;
    public DateTime AppointmentDate { get; set; }
    public string Notes { get; set; } = string.Empty;
    public DateTime CreatedTime { get; set; }
}
