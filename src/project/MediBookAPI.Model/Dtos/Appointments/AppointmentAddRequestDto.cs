

namespace MediBookAPI.Model.Dtos.Appointments;

public sealed record  AppointmentAddRequestDto
{
    public DateTime AppointmentDate { get; set; }

    public string? Notes { get; set; }
}
