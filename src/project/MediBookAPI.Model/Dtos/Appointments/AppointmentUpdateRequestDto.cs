

namespace MediBookAPI.Model.Dtos.Appointments;

public sealed record AppointmentUpdateRequestDto
{
    public int Id { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Notes { get; set; }

   

}
