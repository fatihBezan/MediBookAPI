
using System.Collections.Generic;
using AutoMapper;
using MediCareAPI.Model.Dtos.Appointments;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers.Profiles;

public class AutoMapperConfig:Profile
{
    public AutoMapperConfig()
    {
        CreateMap<AppointmentAddRequestDto, Appointment>();

        CreateMap<AppointmentUpdateRequestDto, Appointment>();

        CreateMap<Appointment, AppointmentResponseDto>();

       

    }
}
