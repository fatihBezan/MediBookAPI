


using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class RoleRepository : EfRepositoryBase<Role, int, BaseDbContext>, IRole
{
    public RoleRepository(BaseDbContext context) : base(context)
    {
    }
}
