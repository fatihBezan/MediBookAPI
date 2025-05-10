using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;
using MediBookAPI.Service.Abstracts;

namespace MediBookAPI.Service.Concretes;

public class RoleService : IRoleService
{
    private readonly IRoleRepository _roleRepository;

    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public void Add(Role role)
    {
        _roleRepository.Add(role);
    }

    public void Delete(int id)
    {
        var role = _roleRepository.GetById(id) ?? 
            throw new Exception("Rol bulunamadı");
        
        _roleRepository.Delete(role);
    }

    public List<Role> GetAll()
    {
        return _roleRepository.GetAll();
    }

    public Role GetById(int id)
    {
        return _roleRepository.GetById(id) ?? 
            throw new Exception("Rol bulunamadı");
    }

    public Role GetByName(string name)
    {
        return _roleRepository.Query().FirstOrDefault(x => x.Name == name) ?? 
            throw new Exception("Rol bulunamadı");
    }

    public void Update(Role role)
    {
        var existingRole = _roleRepository.GetById(role.Id) ?? 
            throw new Exception("Rol bulunamadı");

        _roleRepository.Update(role);
    }
} 