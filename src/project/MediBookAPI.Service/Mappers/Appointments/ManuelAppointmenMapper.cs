

using MediBookAPI.Service.Mappers.Doctors;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Categories;

public sealed class ManuelAppointmenMapper : IAppointmentMapper
{
    public Appointment ConvertToEntity(AppointmentAddRequestDto dto)
    {
        return new Appointment
        {
            Notes = dto.Notes,
            AppointmentDate = dto.AppointmentDate,
            

        };
    }

    public Appointment ConvertToEntity(AppointmentUpdateRequestDto dto)
    {
        return new Appointment
        {
            Id = dto.Id,
            AppointmentDate= dto.AppointmentDate,
            Notes=dto.Notes
        };
    }

    public AppointmentResponseDto ConvertToResponse(Appointment appointment)
    {
        return new AppointmentResponseDto();
    }

    public List<AppointmentResponseDto> ConvertToResponseList(List<Appointment> appointments)
    {
        return appointments.Select(x => ConvertToResponse(x)).ToList();
    }
}
