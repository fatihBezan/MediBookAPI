
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Dtos.Doctors;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Doctors;

public interface IDoctorMapper
{
    Doctor ConvertToEntity(DoctorAddRequestDto dto);
    Doctor ConvertToEntity(DoctorUpdateRequestDto dto);
    DoctorResponseDto ConvertToResponse(Doctor doctor);
    List<DoctorResponseDto> ConvertToResponseList(List<Doctor> doctors);
}
