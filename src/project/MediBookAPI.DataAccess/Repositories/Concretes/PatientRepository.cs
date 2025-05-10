using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class PatientRepository : EfRepositoryBase<Patient, int, BaseDbContext>, IPatientRepository
{
    public PatientRepository(BaseDbContext context) : base(context)
    {
    }
}
