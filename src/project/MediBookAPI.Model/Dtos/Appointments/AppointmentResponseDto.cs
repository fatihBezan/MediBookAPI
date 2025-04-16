

namespace MediCareAPI.Model.Dtos.Appointments;

public sealed record AppointmentResponseDto
{
    
   
    
    public int Id { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Notes { get; set; }
}
