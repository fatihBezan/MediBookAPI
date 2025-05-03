

using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Categories;

public  interface IAppointmentMapper
{
    Appointment ConvertToEntity(AppointmentAddRequestDto dto);
    Appointment ConvertToEntity(AppointmentUpdateRequestDto dto);
    AppointmentResponseDto ConvertToResponse(Appointment appointment);
    List<AppointmentResponseDto> ConvertToResponseList(List<Appointment> appointments);


}
