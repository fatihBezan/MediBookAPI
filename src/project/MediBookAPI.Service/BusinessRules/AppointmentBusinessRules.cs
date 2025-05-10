using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Service.Exceptions;

namespace MediBookAPI.Service.BusinessRules;

public class AppointmentBusinessRules
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IDoctorRepository _doctorRepository;

    public AppointmentBusinessRules(
        IAppointmentRepository appointmentRepository,
        IDoctorRepository doctorRepository)
    {
        _appointmentRepository = appointmentRepository;
        _doctorRepository = doctorRepository;
    }

    public void CheckIfPatientCanMakeAppointment(int patientId, DateTime appointmentDate)
    {
        var lastWeekAppointments = _appointmentRepository.Query()
            .Where(x => x.PatientId == patientId &&
                       x.AppointmentDate >= appointmentDate.AddDays(-7) &&
                       x.AppointmentDate <= appointmentDate)
            .ToList();

        if (lastWeekAppointments.Any())
            throw new BusinessException("Bir hasta bir doktordan 1 hafta içinde en fazla 1 kere randevu alabilir.");
    }

    public void CheckIfDoctorHasAvailableSlot(int hospitalId, string specialty)
    {
        var doctorCount = _doctorRepository.Query()
            .Count(x => x.HospitalId == hospitalId && x.Specialty == specialty);

        if (doctorCount >= 10)
            throw new BusinessException("Bir hastanede aynı uzmanlığa sahip en fazla 10 doktor olabilir.");
    }

    public void CheckIfAppointmentDateIsValid(DateTime appointmentDate)
    {
        if (appointmentDate.Year != 2025)
            throw new BusinessException("Randevu tarihi 2025 yılı için olmalıdır.");
    }
} 