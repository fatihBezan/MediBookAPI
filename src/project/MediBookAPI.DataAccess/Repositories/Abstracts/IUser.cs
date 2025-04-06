

using Core.DataAccess.Repositories;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Abstracts;

public interface IUser : IRepository<User, int>
{

}
