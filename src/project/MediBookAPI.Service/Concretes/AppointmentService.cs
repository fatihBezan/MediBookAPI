using AutoMapper;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Repositories.Concretes;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Service.Helpers;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;
using System;
using MediBookAPI.Service.BusinessRules;

namespace MediBookAPI.Service.Concretes;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly AppointmentBusinessRules _businessRules;

    public AppointmentService(
        IAppointmentRepository appointmentRepository,
        IMapper mapper,
        ICloudinaryHelper cloudinaryHelper,
        AppointmentBusinessRules businessRules)
    {
        _appointmentRepository = appointmentRepository;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
        _businessRules = businessRules;
    }

    public void Add(AppointmentAddRequestDto request)
    {
        _businessRules.CheckIfPatientCanMakeAppointment(request.PatientId, request.AppointmentDate);
        _businessRules.CheckIfAppointmentDateIsValid(request.AppointmentDate);

        var appointment = _mapper.Map<Appointment>(request);
        _appointmentRepository.Add(appointment);
    }

    public void Delete(int id)
    {
        var appointment = _appointmentRepository.GetById(id) ?? 
            throw new Exception("Randevu bulunamadı");
        
        _appointmentRepository.Delete(appointment);
    }

    public List<AppointmentResponseDto> GetAll()
    {
        var appointments = _appointmentRepository.GetAll();
        return _mapper.Map<List<AppointmentResponseDto>>(appointments);
    }

    public AppointmentResponseDto GetById(int id)
    {
        var appointment = _appointmentRepository.GetById(id) ?? 
            throw new Exception("Randevu bulunamadı");
        
        return _mapper.Map<AppointmentResponseDto>(appointment);
    }

    public void Update(AppointmentUpdateRequestDto request)
    {
        var appointment = _appointmentRepository.GetById(request.Id) ?? 
            throw new Exception("Randevu bulunamadı");

        _businessRules.CheckIfAppointmentDateIsValid(request.AppointmentDate);
        
        _mapper.Map(request, appointment);
        _appointmentRepository.Update(appointment);
    }
}
