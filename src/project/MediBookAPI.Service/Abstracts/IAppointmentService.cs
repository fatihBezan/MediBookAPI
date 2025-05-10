using MediBookAPI.Model.Dtos.Appointments;

namespace MediBookAPI.Service.Abstracts;

public interface IAppointmentService
{
    void Add(AppointmentAddRequestDto request);
    void Delete(int id);
    void Update(AppointmentUpdateRequestDto request);
    List<AppointmentResponseDto> GetAll();
    AppointmentResponseDto GetById(int id);
}
