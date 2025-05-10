using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class HospitalRepository : EfRepositoryBase<Hospital, int, BaseDbContext>, IHospitalRepository
{
    public HospitalRepository(BaseDbContext context) : base(context)
    {
    }
}
