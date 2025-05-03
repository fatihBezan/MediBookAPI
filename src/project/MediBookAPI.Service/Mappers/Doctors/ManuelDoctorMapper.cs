

using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Dtos.Doctors;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Doctors;

public sealed class ManuelDoctorMapper : IDoctorMapper
{
    public Doctor ConvertToEntity(DoctorAddRequestDto dto)
    {
        return new Doctor
        {
           FirstName=dto.FirstName,
           LastName=dto.LastName,
           Specialty=dto.Specialty
        };
    }

    public Doctor ConvertToEntity(DoctorUpdateRequestDto dto)
    {
        return new Doctor
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Specialty = dto.Specialty
        };
    }

    public DoctorResponseDto ConvertToResponse(Doctor doctor)
    {
        return new DoctorResponseDto();
    }

    public List<DoctorResponseDto> ConvertToResponseList(List<Doctor> doctors)
    {
        return doctors.Select(x => ConvertToResponse(x)).ToList();
    }
}
