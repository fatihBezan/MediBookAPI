

using MediBookAPI.Model.Dtos.Doctors;

namespace MediBookAPI.Service.Abstracts;

public interface IDoctorService
{
    void Add(DoctorAddRequestDto dto);

    void Update(DoctorUpdateRequestDto dto);

    List<DoctorResponseDto> GetAll();

    DoctorResponseDto? GetById(int id);

    void Delete(int id);    

    List<DoctorResponseDto> GetSpecialty(string Specialty);

    List<DoctorResponseDto?> GetHospitalId(int id);
}
