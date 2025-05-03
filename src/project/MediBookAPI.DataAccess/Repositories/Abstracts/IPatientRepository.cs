

using Core.DataAccess.Repositories;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Abstracts;

public interface IPatientRepository : IRepository<Patient, int>
{

}
