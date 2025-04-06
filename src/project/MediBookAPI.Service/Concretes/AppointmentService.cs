

using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Repositories.Concretes;
using MediBookAPI.Service.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Dtos.Appointments;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.Service.Concretes;

public sealed class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentsRepository;

    public AppointmentService(IAppointmentRepository appointmentsRepository)
    {
        _appointmentsRepository = appointmentsRepository;
    }

    public void Add(AppointmentAddRequestDto dto)
    {
        Appointment appointment = new()
        {
            Notes=dto.Notes
        } ;

        _appointmentsRepository.Add(appointment);
    }

    public void Delete(int id)
    {
        var appointment=_appointmentsRepository.GetById(id);

        if (appointment == null)  
        {
            //exception fırlat
        }
        _appointmentsRepository.Delete(appointment!);
    }

    public List<AppointmentResponseDto> GetAll()
    {
       List<Appointment> appointments = _appointmentsRepository.GetAll();
        List<AppointmentResponseDto> result = new List<AppointmentResponseDto>();

        foreach (Appointment item in appointments) 
        {
            AppointmentResponseDto appointmentResponseDto = new AppointmentResponseDto();
            result.Add(appointmentResponseDto);
        }
        return result;  
    }

    public AppointmentResponseDto GetById(int id)
    {
        Appointment? appointment =_appointmentsRepository.GetById(id) ;

        if (appointment is null)
        {
           //exception fırlat 
        }

        AppointmentResponseDto appointmentResponseDto=new AppointmentResponseDto();

        return appointmentResponseDto;  
    }

    public void Update(AppointmentUpdateRequestDto dto)
    {
        Appointment? appointment = _appointmentsRepository.GetById(dto.Id);
        if (appointment is null)
        {
            //exception fırlat
        }

        _appointmentsRepository.Update(appointment);
    }
}
