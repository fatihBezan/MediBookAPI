using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Abstracts;

public interface IPatientService
{
    void Add(Patient patient);
    void Update(Patient patient);
    void Delete(int id);
    List<Patient> GetAll();
    Patient GetById(int id);
} 