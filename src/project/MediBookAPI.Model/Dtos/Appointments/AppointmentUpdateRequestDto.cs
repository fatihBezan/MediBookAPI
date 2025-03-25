

namespace MediCareAPI.Model.Dtos.Appointments;

public sealed record AppointmentUpdateRequestDto
{
    public DateTime AppointmentDate { get; set; }

    public string? Notes { get; set; }
}
