

using Core.DataAccess.Repositories;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Abstracts;

public interface IPatientRepository : IRepository<Patient, int>
{

}
