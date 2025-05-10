using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;
using MediBookAPI.Service.Abstracts;

namespace MediBookAPI.Service.Concretes;

public class HospitalService : IHospitalService
{
    private readonly IHospitalRepository _hospitalRepository;

    public HospitalService(IHospitalRepository hospitalRepository)
    {
        _hospitalRepository = hospitalRepository;
    }

    public void Add(Hospital hospital)
    {
        _hospitalRepository.Add(hospital);
    }

    public void Delete(int id)
    {
        var hospital = _hospitalRepository.GetById(id) ?? 
            throw new Exception("Hastane bulunamadı");
        
        _hospitalRepository.Delete(hospital);
    }

    public List<Hospital> GetAll()
    {
        return _hospitalRepository.GetAll();
    }

    public Hospital GetById(int id)
    {
        return _hospitalRepository.GetById(id) ?? 
            throw new Exception("Hastane bulunamadı");
    }

    public void Update(Hospital hospital)
    {
        var existingHospital = _hospitalRepository.GetById(hospital.Id) ?? 
            throw new Exception("Hastane bulunamadı");

        _hospitalRepository.Update(hospital);
    }
} 