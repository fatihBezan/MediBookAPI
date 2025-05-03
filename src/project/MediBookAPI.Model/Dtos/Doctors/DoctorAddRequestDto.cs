
namespace MediBookAPI.Model.Dtos.Doctors;

public sealed record  DoctorAddRequestDto
{

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Specialty { get; set; }

   
}
