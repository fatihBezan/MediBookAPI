using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;
using MediBookAPI.Service.Abstracts;

namespace MediBookAPI.Service.Concretes;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public void Add(Patient patient)
    {
        _patientRepository.Add(patient);
    }

    public void Delete(int id)
    {
        var patient = _patientRepository.GetById(id) ?? 
            throw new Exception("Hasta bulunamadı");
        
        _patientRepository.Delete(patient);
    }

    public List<Patient> GetAll()
    {
        return _patientRepository.GetAll();
    }

    public Patient GetById(int id)
    {
        return _patientRepository.GetById(id) ?? 
            throw new Exception("Hasta bulunamadı");
    }

    public void Update(Patient patient)
    {
        var existingPatient = _patientRepository.GetById(patient.Id) ?? 
            throw new Exception("Hasta bulunamadı");

        _patientRepository.Update(patient);
    }
} 