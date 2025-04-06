


using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUser
{
    public UserRepository(BaseDbContext context) : base(context)
    {
    }
}
