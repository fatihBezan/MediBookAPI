using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class DoctorRepository : EfRepositoryBase<Doctor, int, BaseDbContext>, IDoctorRepository
{
    public DoctorRepository(BaseDbContext context) : base(context)
    {
    }
}
