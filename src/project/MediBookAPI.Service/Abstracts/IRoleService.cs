using MediBookAPI.Model.Entities;

namespace MediBookAPI.Service.Abstracts;

public interface IRoleService
{
    void Add(Role role);
    void Update(Role role);
    void Delete(int id);
    List<Role> GetAll();
    Role GetById(int id);
    Role GetByName(string name);
} 