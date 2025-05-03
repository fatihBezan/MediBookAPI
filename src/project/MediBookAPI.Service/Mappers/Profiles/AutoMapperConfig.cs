
using System.Collections.Generic;
using AutoMapper;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Dtos.Doctors;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Profiles;

public class AutoMapperConfig:Profile
{
    public AutoMapperConfig()
    {
        CreateMap<AppointmentAddRequestDto, Appointment>();

        CreateMap<AppointmentUpdateRequestDto, Appointment>();

        CreateMap<Appointment, AppointmentResponseDto>();

       CreateMap<DoctorAddRequestDto,Doctor>();
        CreateMap<Doctor,DoctorResponseDto>();

    }
}
