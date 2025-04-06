

using MediCareAPI.Model.Dtos.Appointments;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers;

public sealed class AppointmentMapper
{
    public Appointment ConvertToEntity(AppointmentAddRequestDto dto)
    {
        return new Appointment
        {
            Notes=dto.Notes
        };
    }

    public Appointment ConvertToEntity(AppointmentUpdateRequestDto dto)
    {
        return new Appointment
        {
            Id=dto.Id,
            Notes = dto.Notes
        };
    }

    public AppointmentResponseDto ConvertToResponse(Appointment appointment) 
    {
        return new AppointmentResponseDto();
    }

    public List<AppointmentResponseDto> ConvertToResponseList(List<Appointment> appointments)  
    {
        return appointments.Select(x=>ConvertToResponse(x)).ToList();
    }

}
