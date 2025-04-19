


using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class DoctorRepository : EfRepositoryBase<Doctor, int, BaseDbContext>, IDoctorRepository
{
    public DoctorRepository(BaseDbContext context) : base(context)
    {
    }
}
