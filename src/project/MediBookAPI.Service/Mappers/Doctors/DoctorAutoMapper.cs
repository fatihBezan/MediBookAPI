

using AutoMapper;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Dtos.Doctors;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Doctors;

public sealed class DoctorAutoMapper:IDoctorMapper
{
    private readonly IMapper _mapper;

    public DoctorAutoMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Doctor ConvertToEntity(DoctorAddRequestDto dto)
    {
        return _mapper.Map<Doctor>(dto);
    }

    public Doctor ConvertToEntity(DoctorUpdateRequestDto dto)
    {
        return _mapper.Map<Doctor>(dto);
    }

    public DoctorResponseDto ConvertToResponse(Doctor doctor)
    {
        return _mapper.Map<DoctorResponseDto>(doctor);
    }

    public List<DoctorResponseDto> ConvertToResponseList(List<Doctor> doctors)
    {
        return _mapper.Map<List<DoctorResponseDto>>(doctors);
    }
}
