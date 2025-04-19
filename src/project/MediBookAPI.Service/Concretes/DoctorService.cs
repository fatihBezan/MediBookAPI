
using AutoMapper;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Service.Abstracts;
using MediCareAPI.Model.Dtos.Doctors;

namespace MediBookAPI.Service.Concretes;

public sealed class DoctorService : IDoctorService
{
    private IDoctorRepository   _doctorRepository;
    private IMapper _mapper;

    public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
    {
        _doctorRepository = doctorRepository;
        _mapper = mapper;
    }

    public void Add(DoctorAddRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<DoctorResponseDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public DoctorResponseDto? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<DoctorResponseDto?> GetHospitalId(int id)
    {
        throw new NotImplementedException();
    }

    public List<DoctorResponseDto> GetSpecialty(string Specialty)
    {
        throw new NotImplementedException();
    }

    public void Update(DoctorUpdateRequestDto dto)
    {
        throw new NotImplementedException();
    }
}
