

namespace MediBookAPI.Model.Dtos.Hospitals;

public sealed record HospitalUpdateRequestDto
{
 

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

}
