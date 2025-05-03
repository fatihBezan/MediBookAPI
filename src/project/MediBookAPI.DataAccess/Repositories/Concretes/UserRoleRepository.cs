using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class UserRoleRepository : EfRepositoryBase<UserRole, int, BaseDbContext>, IUserRoleRepository
{
    public UserRoleRepository(BaseDbContext context) : base(context)
    {
    }
}