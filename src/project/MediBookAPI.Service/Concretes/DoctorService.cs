
using AutoMapper;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Repositories.Concretes;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Dtos.Doctors;
using MediBookAPI.Model.Entities;

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
        Doctor doctor = new()
        {
            FirstName=dto.FirstName,
            LastName=dto.LastName,
            Specialty=dto.Specialty
        };
        _doctorRepository.Add(doctor);  
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<DoctorResponseDto> GetAll()
    {

        List<Doctor> doctors = _doctorRepository.GetAll();
        return _mapper.Map<List<DoctorResponseDto>>(doctors);
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
