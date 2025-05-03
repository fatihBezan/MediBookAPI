using AutoMapper;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Repositories.Concretes;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Service.Helpers;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;
using System;

namespace MediBookAPI.Service.Concretes;

public sealed class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentsRepository;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;

    public AppointmentService(IAppointmentRepository appointmentsRepository, IMapper mapper, ICloudinaryHelper cloudinaryHelper)
    {
        _appointmentsRepository = appointmentsRepository;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
    }

    public void Add(AppointmentAddRequestDto dto)
    {
        Appointment appointment = new()
        {
            Notes = dto.Notes,
            AppointmentDate = dto.AppointmentDate
        };

        _appointmentsRepository.Add(appointment);
    }

    public void Delete(int id)
    {
        var appointment = _appointmentsRepository.GetById(id);

        if (appointment == null)
        {
            throw new ArgumentException($"Appointment with id {id} not found");
        }
        _appointmentsRepository.Delete(appointment);
    }

    public List<AppointmentResponseDto> GetAll()
    {
        List<Appointment> appointments = _appointmentsRepository.GetAll();
        return _mapper.Map<List<AppointmentResponseDto>>(appointments);
    }

    public AppointmentResponseDto GetById(int id)
    {
        Appointment? appointment = _appointmentsRepository.GetById(id);

        if (appointment is null)
        {
            throw new ArgumentException($"Appointment with id {id} not found");
        }

        return _mapper.Map<AppointmentResponseDto>(appointment);
    }

    public void Update(AppointmentUpdateRequestDto dto)
    {
        Appointment? appointment = _appointmentsRepository.GetById(dto.Id);
        if (appointment is null)
        {
            throw new ArgumentException($"Appointment with id {dto.Id} not found");
        }

        _mapper.Map(dto, appointment);
        _appointmentsRepository.Update(appointment);
    }
}
