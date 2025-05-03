using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class RoleRepository : EfRepositoryBase<Role, int, BaseDbContext>, IRoleRepository
{
    public RoleRepository(BaseDbContext context) : base(context)
    {
    }
}
