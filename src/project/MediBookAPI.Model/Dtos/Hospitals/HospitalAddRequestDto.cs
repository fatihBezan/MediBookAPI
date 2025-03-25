


namespace MediCareAPI.Model.Dtos.Hospitals;

public sealed record HospitalAddRequestDto
{
  

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
