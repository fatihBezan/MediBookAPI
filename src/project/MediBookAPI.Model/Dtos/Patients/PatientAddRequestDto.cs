
namespace MediCareAPI.Model.Dtos.Patients;

public sealed record PatientAddRequestDto
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime BirthDate { get; set; }
}
