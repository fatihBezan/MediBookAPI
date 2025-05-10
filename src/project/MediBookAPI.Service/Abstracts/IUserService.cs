using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Abstracts;

public interface IUserService
{
    void Add(User user);
    void Update(User user);
    void Delete(int id);
    List<User> GetAll();
    User GetById(int id);
    User GetByUsername(string username);
} 