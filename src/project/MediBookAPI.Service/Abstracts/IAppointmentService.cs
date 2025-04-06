

using MediCareAPI.Model.Dtos.Appointments;

namespace MediBookAPI.Service.Abstracts;

public interface IAppointmentService
{
    void Add(AppointmentAddRequestDto dto);
    void Update(AppointmentUpdateRequestDto dto);
    void Delete(int id);

    List<AppointmentResponseDto> GetAll();

    AppointmentResponseDto GetById(int id); 
}
