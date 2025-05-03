using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context) : base(context)
    {
    }
}
