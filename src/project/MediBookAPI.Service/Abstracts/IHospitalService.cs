using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Abstracts;

public interface IHospitalService
{
    void Add(Hospital hospital);
    void Update(Hospital hospital);
    void Delete(int id);
    List<Hospital> GetAll();
    Hospital GetById(int id);
} 