


using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class UserRoleRepository : EfRepositoryBase<UserRole, int, BaseDbContext>, IUserRole
{
    public UserRoleRepository(BaseDbContext context) : base(context)
    {
    }
}