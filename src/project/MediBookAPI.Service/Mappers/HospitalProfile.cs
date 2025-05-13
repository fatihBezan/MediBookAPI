using AutoMapper;
using MediBookAPI.Model.Dtos.Hospitals;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Mappers;

public class HospitalProfile : Profile
{
    public HospitalProfile()
    {
        CreateMap<HospitalAddRequestDto, Hospital>();
        CreateMap<HospitalUpdateRequestDto, Hospital>();
        // Gerekirse ters yönlü mapping de ekleyebilirsiniz
        // CreateMap<Hospital, HospitalAddRequestDto>();
    }
} 