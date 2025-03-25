
namespace MediCareAPI.Model.Dtos.Doctors;

public sealed record DoctorUpdateRequestDto
{

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Specialty { get; set; }
}
