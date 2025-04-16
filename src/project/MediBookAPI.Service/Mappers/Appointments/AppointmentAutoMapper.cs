

using AutoMapper;
using MediCareAPI.Model.Dtos.Appointments;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Categories;

public sealed class AppointmentAutoMapper : IAppointmentMapper
{
    private readonly IMapper _mapper;

    public AppointmentAutoMapper(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Appointment ConvertToEntity(AppointmentAddRequestDto dto)
    {
         return _mapper.Map<Appointment>(dto);
    }

    public Appointment ConvertToEntity(AppointmentUpdateRequestDto dto)
    {
        return _mapper.Map<Appointment>(dto);
    }

    public AppointmentResponseDto ConvertToResponse(Appointment appointment)
    {
        return _mapper.Map<AppointmentResponseDto>(appointment);
    }

    public List<AppointmentResponseDto> ConvertToResponseList(List<Appointment> appointments)
    {
        return _mapper.Map<List<AppointmentResponseDto>>(appointments);
    }
}
