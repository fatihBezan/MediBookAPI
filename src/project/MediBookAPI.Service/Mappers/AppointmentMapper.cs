using AutoMapper;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers;

public class AppointmentProfile : Profile
{
    public AppointmentProfile()
    {
        CreateMap<AppointmentAddRequestDto, Appointment>();

        CreateMap<Appointment, AppointmentResponseDto>()
            .ForMember(dest => dest.DoctorFullName,
                opt => opt.MapFrom(src => $"{src.Doctor.FirstName} {src.Doctor.LastName}"))
            .ForMember(dest => dest.PatientFullName,
                opt => opt.MapFrom(src => $"{src.Patient.FirstName} {src.Patient.LastName}"));
    }
} 